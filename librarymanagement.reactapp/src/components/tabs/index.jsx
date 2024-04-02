import * as React from 'react';
import PropTypes from 'prop-types';
import Tabs from '@mui/material/Tabs';
import Tab from '@mui/material/Tab';
import Typography from '@mui/material/Typography';
import Box from '@mui/material/Box';

import { useEffect, useState, useRef } from "react";
import { useParams} from "react-router-dom";
import feedBackApi from "api/feedBackApi";
import jwt from "jwt-decode";
import Rating from "@mui/material/Rating";
import moment from "moment";
import userAccountAPI from "api/accountApi";
import publishedBookApi from "api/publishedBookApi";
import { useForm } from "react-hook-form";
import Alert from "components/alert";

function CustomTabPanel(props) {
  const { children, value, index, ...other } = props;

  return (
    <div
      role="tabpanel"
      hidden={value !== index}
      id={`simple-tabpanel-${index}`}
      aria-labelledby={`simple-tab-${index}`}
      {...other}
    >
      {value === index && (
        <Box sx={{ p: 3 }}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </div>
  );
}

CustomTabPanel.propTypes = {
  children: PropTypes.node,
  index: PropTypes.number.isRequired,
  value: PropTypes.number.isRequired,
};

function a11yProps(index) {
  return {
    id: `simple-tab-${index}`,
    'aria-controls': `simple-tabpanel-${index}`,
  };
}

export default function BasicTabs() {
  const [valueX, setValueX] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValueX(newValue);
  };

  const { id } = useParams();
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [value, setValue] = useState(null);
  const [feedBackList, setfeedBackList] = useState([]);
  const [user, setUser] = useState(null);
  const { register, handleSubmit, reset } = useForm();
  const [bookRelatedList, setBookRelatedList] = useState([]);

  useEffect(() => {
    const getFeedBack = async () => {
      const data = await feedBackApi.GetFeedBack(id);
      setfeedBackList(data);
    };
    getFeedBack();

    const getUser = async () => {
      const user = await userAccountAPI.GetUserAccount(userLogin.id);
      setUser(user);
    };
    getUser();

    const getBookRelatedList = async () => {
        const bookList = await publishedBookApi.GetBookRelatedList(id);
        setBookRelatedList(bookList);
      };
    getBookRelatedList();
  }, []);

  const formRef = useRef(null);
  
  const addFeedBack = async (content) => {
    const formData = new FormData();
    formData.append("Content", content.content);
    formData.append("UserAccountId", userLogin.id);
    formData.append("PublishedBookId", id);
    formData.append("Rate", value);
    await feedBackApi.AddFeedBack(formData).then(async (res) => {
      if (res.statusCode === 200) {
        Alert.showSuccessAlert("Your post have been posted sucessfully!");
      }
      Alert.showErrorAlert(res.message);
      if (formRef.current) {
        formRef.current.reset();
      }
      reset();
    });
    const data = await feedBackApi.GetFeedBack(id);
    setfeedBackList(data);
  };

  return (
    <Box sx={{ width: '100%' }}>
      <Box sx={{ borderBottom: 1, borderColor: 'divider' }}>
        <Tabs value={valueX} onChange={handleChange} aria-label="basic tabs example">
          <Tab label="Location" {...a11yProps(0)} />
          <Tab label="Comments" {...a11yProps(1)} />
        </Tabs>
      </Box>
      <CustomTabPanel value={valueX} index={0}>
        <table className="w-full">
            <thead>
            <tr>
                <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">#</p>
                </th>
                <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                        Book Code
                    </p>
                </th>
                <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                        Status
                    </p>
                </th>
                <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                        Action
                    </p>
                </th>
            </tr>
            </thead>
            <tbody>
                {bookRelatedList?.map((item, index) => (
                    <tr className="items-center border-b-2 hover:bg-gray-100">
                        <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                            <p> {index + 1} </p>
                        </td>
                        <td className="items-center pb-[18px] pt-[14px] sm:text-[15px]">
                            <p> {item.code} </p>
                        </td>
                        <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                            <p> {item.status} {item.status == "Borrowing" ? "(Due time: " + moment(item.dueTime).format("DD/MM/YYYY") + ")" : null }</p>
                        </td>
                        <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                            <p> Action</p>
                        </td>
                    </tr>
                ))}
            </tbody>
        </table>
      </CustomTabPanel>
      <CustomTabPanel value={valueX} index={1}>
        <div className="flex flex-col justify-center">
          <div>
            <form ref={formRef} onSubmit={handleSubmit(addFeedBack)}>
                <div className="flex flex-col rounded-[10px] bg-clip-border shadow-3xl shadow-shadow-500 dark:!bg-navy-800 dark:text-white dark:shadow-none">
                    <div className="flex items-center justify-start">
                        <img
                        src={user?.avatar}
                        className="ml-3 mr-3 h-[35px] w-[35px] rounded-full "
                        alt=""
                        />
                        <input
                        className="autofocus placeholder-shown:border-blue-gray-200 disabled:bg-blue-gray-50 focus:border-1 linear mb-2 mr-3 mt-2 w-full resize-none rounded-[10px] rounded-[7px] bg-lightPrimary px-3 px-4 py-2 py-2.5 font-sans text-sm font-medium font-normal outline-0 transition transition-all duration-200 hover:bg-gray-100 focus:outline-0 active:bg-gray-200 disabled:resize-none disabled:border-0 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                        type="text"
                        placeholder="Let's share about this book!"
                        {...register("content")}
                        />
                    </div>
                    <div className="row ml-[65px] flex items-center justify-between mb-2">
                        <div className="row flex items-center">
                            <span className="mr-4 text-base text-gray-600">
                                How would you rate this book?
                            </span>

                            <Rating
                                className="items-center"
                                name="half-rating"
                                value={value}
                                defaultValue={0}
                                precision={0.5}
                                onChange={(event, newValue) => {
                                    setValue(newValue);
                                }}
                            />
                        </div>
                        <button className="linear ml-20 mr-3 cursor-pointer rounded-[10px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90">
                            Send
                        </button>
                    </div>
                </div>
            </form>
            <div className="mb-2 ml-4 mt-4 text-[18px] font-bold  text-navy-700">
              <span>All feadbacks (1) 5/5 </span>
            </div>
            {feedBackList === null && (
              <div className="flex flex-col items-center justify-center">
                <p className="mt-48 text-xl text-gray-700">
                  Feedbacks is empty!
                </p>
              </div>
            )}
            <div className="h-[150px]">
              {feedBackList?.map((item) => (
                <div
                  className={`mb-1 mt-1 flex items-center justify-between rounded-2xl border-2 bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none`}
                >
                  <div key={item.id} className="row flex items-center justify-between w-full">
                    <div className="ml-4">
                      <p className={`text-m text-navy-700 dark:text-white`}>
                        {item.content}
                      </p>
                      <div className="mt-1 flex items-center gap-2">
                        <img
                          src={item.userAvatar}
                          className={` h-[35px] w-[35px] rounded-full`}
                        />

                        <div className="ml-2">
                          <p
                            className={`text-m font-medium text-navy-700 dark:text-white`}
                          >
                            {item.userName}
                          </p>
                        </div>
                      </div>
                    </div>
                    <div className="ml-[200px]">
                      <span className="mr-4 text-base text-gray-600">
                        {moment(item.createdDate).format("DD/MM/YYYY HH:mm A")}
                      </span>
                      <div>
                        <Rating
                          className="items-center"
                          name="half-rating"
                          size="small"
                          precision={0.5}
                          value={item.rate}
                        />
                      </div>
                    </div>
                  </div>
                </div>
              ))}
            </div>
          </div>
        </div>
      </CustomTabPanel>
    </Box>
  );
}