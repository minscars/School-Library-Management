import React from "react";
import Link from "@mui/material/Link";
import { MdOutlineModeComment } from "react-icons/md";
import moment from "moment";
const post = ({ data }) => {
  
  return (
    <div
      className={`mb-1 mt-1 flex w-full items-center justify-between rounded-[2px] rounded-[5px] border-2 bg-white p-3 shadow-3xl shadow-shadow-500 hover:bg-gray-300 dark:!bg-navy-700 dark:shadow-none`}
    >
      <div className="flex items-center">
        <div className="ml-2">
          <p
            className={`text-[17px] font-bold text-navy-700 hover:underline dark:text-white`}
          >
            {data.title}
          </p>
          <div className="flex items-center justify-between">
            <div className="mt-2 flex w-[550px] items-center">
              <img
                src={data.avatar}
                className={` h-[35px] w-[35px] rounded-full`}
              />

              <div className="ml-2">
                <p
                  className={` text-m font-bold text-navy-700 dark:text-white`}
                >
                  {data.userName}
                </p>
                <p className="text-sm font-medium text-navy-700 dark:text-white">
                  {moment(data.createdDate).format("DD/MM/YYYY HH:mm")}
                </p>
              </div>
            </div>
            <div className="right-0 float-right mt-6 flex items-center">
              <MdOutlineModeComment />
              <p className="ml-1 text-sm font-medium text-navy-700 dark:text-white">
                {data.totalComments} comments
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default post;
