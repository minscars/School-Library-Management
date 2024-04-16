import React from "react";
import { Link } from "react-router-dom";
import { MdArrowForward } from "react-icons/md";
import moment from "moment";
const post = ({ data }) => {
  return (
    <div
      className={` mb-1 mt-1 flex w-full items-center justify-between rounded-[2px] border-2 bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none`}
    >
      <div className="flex items-center">
        {/* <div className="">
          <img className="h-auto w-[83px] rounded-lg" src={data.image} alt="" />
        </div> */}
        <div className="ml-4">
          <p className={`text-l font-bold text-navy-700 dark:text-white`}>
            {data.title}
          </p>
          <div className="mt-1 flex items-center gap-2">
            <img
              src={data.avatar}
              className={` h-[35px] w-[35px] rounded-full`}
            />

            <div className="ml-2">
              <p
                className={` text-m font-medium text-navy-700 dark:text-white`}
              >
                {data.username}
              </p>
              <p className="text-sm font-medium text-navy-700 dark:text-white">
                {moment(data.createDate).format("DD/MM/YYYY HH:mm A")}
              </p>
            </div>
            <div className="ml-[100px]">
              <p className="text-sm font-medium text-navy-700 dark:text-white">
                comments
              </p>
            </div>
          </div>
        </div>
      </div>
      <div className="mr-4 flex items-center justify-center text-gray-600 dark:text-white">
        <Link to={`/user/forum/detail/${data.id}`}>
          <MdArrowForward />
        </Link>
      </div>
    </div>
  );
};

export default post;
