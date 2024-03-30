import Card from "components/card";
import { useEffect, useState, useRef } from "react";
import { Link } from "react-router-dom";
import { ToastContainer, toast } from "react-toastify";
import publishedBookApi from "../../../api/publishedBookApi";
import { useParams, useNavigate } from "react-router-dom";
import { MdArrowBackIos } from "react-icons/md";
import feedBackApi from "api/feedBackApi";
import bookRequestApi from "api/bookRequest";
import jwt from "jwt-decode";
import Rating from "@mui/material/Rating";
import * as React from "react";
import moment from "moment";
import userAccountAPI from "api/accountApi";
import { useForm } from "react-hook-form";
import Alert from "components/alert";
import Swal from "sweetalert2";
const Detail = () => {
  const [book, setBook] = useState([]);
  const { id } = useParams();
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [value, setValue] = useState(null);
  const [feedBackList, setfeedBackList] = useState([]);
  const [user, setUser] = useState(null);
  const { register, handleSubmit, reset } = useForm();
  const navigate = useNavigate();
  useEffect(() => {
    const getbyid = async () => {
      const data = await publishedBookApi.GetById(id);
      setBook(data);
    };
    getbyid();
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
  }, []);

  const formRef = useRef(null);
  const handleClick = async (id) => {
    var publishedBookId = id;
    var userAccountId = userLogin.id;
    const dto = { userAccountId, publishedBookId };

    Swal.fire({
      title: "Are you sure?",
      text: "You should recheck your information before open request to borrow this book!",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, I checked it!",
    }).then(async (result) => {
      if (result.isConfirmed) {
        await bookRequestApi.CreateNewBookRequest(dto).then(async (res) => {
          if (res.statusCode === 200) {
            Alert.showSuccessAlert(res.message);
            navigate(`/user/history/detail/${res.data}`);
          } else {
            Alert.showErrorAlert(res.message);
          }
        });
      }
    });
  };

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
  //setfeedBackList(feedBackList);

  return (
    <div className="gap-5 xl:grid-cols-2">
      <Card extra={"w-full h-full px-6 pb-6 sm:overflow-x-auto"}>
        <div className="mb-5 mt-5 flex h-full w-full overflow-x-scroll xl:overflow-hidden">
          <Link to={"/user/books"}>
            <MdArrowBackIos className="mr-2 rounded-full text-[20px]" />
          </Link>
          <img
            src={book.image}
            className="mr-6 flex h-[300px] w-auto rounded-xl border-2 shadow-3xl shadow-shadow-500"
          />
          <div className="">
            <p className="text-[24px] font-bold  text-indigo-700">
              {book.title}
            </p>
            <p className="mt-2 text-[18px] font-bold text-cyan-500">
              {" "}
              {book.category}
            </p>
            <p className="mt-2 text-[18px] font-bold text-cyan-500">
              {" "}
              <span className="mb-10 text-[18px] font-bold  text-navy-700">
                {" "}
                Borrowed: {book.checkout_visit}
              </span>
            </p>
            <p className="mr-4 mt-2 text-justify text-base text-gray-600">
              <span className="mb-10 text-[18px] font-bold  text-navy-700">
                Description:{"  "}
              </span>
              Khi ngợi khen một người trẻ độc lập mạnh mẽ, có thể chúng ta không
              biết họ lớn lên trong môi trường phải làm bố mẹ của bố mẹ mình ra
              sao, cô đơn khắc khoải thế nào. Khi ngưỡng một một người trẻ học
              giỏi, có thể chúng ta không biết họ đã bị ngạt thở bởi kỳ vọng của
              cha mẹ. Khi phán xét một người trẻ hời hợt thiếu động lực sống, có
              thể chúng ta không biết từ bé đến lớn họ đã được "đút sẵn" đến nỗi
              không còn biết mình là ai. Khi kêu ca một người trẻ thiếu nghị lực
              muốn kết thúc cuộc sống, có thể chúng ta không biết họ đã oằn mình
              mang gánh nặng mà gia đình ấn xuống quá lâu, khiến cánh giải thoát
              duy nhất là cái chết…
            </p>
            <div className="mt-[10px]">
              <button
                onClick={() => handleClick(book.id)}
                className="linear rounded-[15px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
              >
                Borrow
              </button>
              <ToastContainer />
            </div>
          </div>
        </div>
        <div class="mb-4 h-px bg-gray-300 dark:bg-white/30" />
        <div className="flex flex-col items-center justify-center">
          <span className="align-center mb-2 text-[20px] font-bold text-customcolor-500">
            Feedback & Vote
          </span>
          <div>
            <form ref={formRef} onSubmit={handleSubmit(addFeedBack)}>
              <div className="flex items-center justify-center rounded-[10px] bg-clip-border shadow-3xl shadow-shadow-500 dark:!bg-navy-800 dark:text-white dark:shadow-none">
                <img
                  src={user?.avatar}
                  className="ml-3 mr-3 h-[35px] w-[35px] rounded-full "
                  alt=""
                />
                <input
                  className="autofocus placeholder-shown:border-blue-gray-200 disabled:bg-blue-gray-50 focus:border-1 linear mb-2 mr-3 mt-2 w-[500px] resize-none rounded-[10px] rounded-[7px] bg-lightPrimary px-3 px-4 py-2 py-2.5 font-sans text-sm font-medium font-normal outline-0 transition transition-all duration-200 hover:bg-gray-100 focus:outline-0 active:bg-gray-200 disabled:resize-none disabled:border-0 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                  type="text"
                  placeholder="Let's share about this book!"
                  {...register("content")}
                />
              </div>
              <div className="row ml-[65px] flex items-center">
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
                <button className="linear ml-20 cursor-pointer rounded-[10px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90">
                  Send
                </button>
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
            <div className="h-[150px] overflow-y-scroll">
              {feedBackList?.map((item) => (
                <div
                  className={`mb-1 mt-1 flex w-full items-center justify-between rounded-2xl border-2 bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none`}
                >
                  <div key={item.id} className="row flex items-center">
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
      </Card>
    </div>
  );
};

export default Detail;
