import TooltipHorizon from "components/tooltip";
import moment from "moment";
import { MdOutlineReply, MdSend } from "react-icons/md";
import React, { useState } from "react";
import { Typography } from "@mui/material";
import commentApi from "api/commentApi";
import Alert from "components/alert";
import { toast } from "react-toastify";
export default function Comment(props) {
  const [openReply, setOpenReply] = useState(false);
  const [replyContent, setReplyContent] = useState("");
  const handleAddReply = (id) => {
    if (id === props?.item?.id) {
      setOpenReply(!openReply);
    }
  };
  const replyCommnet = async (commentId) => {
    var userAccountId = props.userId;
    var content = replyContent;
    var replyCommentId = commentId;
    var blogId = props.blogId;
    var dto = { blogId, userAccountId, content, replyCommentId };
    console.log(dto);
    await commentApi.CreateCommnet(dto).then(async (res) => {
      if (res.statusCode === 200) {
        toast.success(res.message);
        //Alert.showSuccessAlert("Your post have been posted sucessfully!");
        props
          .setTrigger(Math.random() + 1)
          ?.toString(36)
          .substring(7);
        setReplyContent("");
      }
    });
  };
  return (
    <>
      <div className="row ml-20 mt-2 flex w-fit items-center">
        <div className="ml-3 flex gap-2">
          <img
            src={props.item.userAvatar}
            className={`mt-2 h-[36px] w-[36px] rounded-full`}
          />

          <div className="ml-2 rounded-2xl border-2 bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none">
            <p className={`text-m font-bold text-navy-700 dark:text-white`}>
              {props.item.userName}{" "}
              <span className="mr-4 text-sm text-gray-600">
                {" "}
                {moment(props.item.createdDate).format("DD/MM/YYYY HH:mm A")}
              </span>
            </p>
            <p className="text-m font-medium text-navy-700 dark:text-white">
              {props.item.content}
            </p>
          </div>
        </div>
        <TooltipHorizon
          trigger={
            <button onClick={() => handleAddReply(props?.item?.id)}>
              <MdOutlineReply className="ml-2 h-5 w-5 text-gray-600" />
            </button>
          }
          content={<p className="font-bold text-gray-700">Reply</p>}
          placement="right"
        />
      </div>
      <div className="ml-40 mt-2">
        {props.item.listReplyComments?.map((item) => (
          <div className="mb-2 flex gap-2">
            <img
              src={item.userAvatar}
              className={`mt-2 h-[36px] w-[36px] rounded-full`}
            />

            <div className="ml-1  rounded-2xl border-2 bg-white p-2 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none">
              <p className={`text-m font-bold text-navy-700 dark:text-white`}>
                {item.userName}{" "}
                <span className="mr-4 text-sm text-gray-600">
                  {" "}
                  {moment(item.createdDate).format("DD/MM/YYYY HH:mm A")}
                </span>
              </p>
              <p className="text-m font-medium text-navy-700 dark:text-white">
                {item.content}
              </p>
            </div>
          </div>
        ))}
        {openReply && (
          <div className="flex gap-2">
            <div className="flex gap-2">
              <img
                src={props.item.userAvatar}
                className={`mt-2 h-[36px] w-[36px] rounded-full`}
              />
              <div>
                <div className="autofocus placeholder-shown:border-blue-gray-200 disabled:bg-blue-gray-50 focus:border-1 linear  flex w-[750px] resize-none items-center rounded-[10px] rounded-[7px] bg-lightPrimary px-3 py-1.5 font-sans text-sm font-medium font-normal outline-0 transition transition-all duration-200 hover:bg-gray-100 focus:outline-0 active:bg-gray-200 disabled:resize-none disabled:border-0 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20">
                  <input
                    className="autofocus placeholder-shown:border-blue-gray-200 disabled:bg-blue-gray-50 focus:border-1 linear mb-2 mr-3 mt-2 w-[700px] resize-none rounded-[10px] rounded-[7px]  px-3 px-4 py-2 py-2.5 font-sans text-sm font-medium font-normal outline-0 transition transition-all duration-200 focus:outline-0 active:bg-gray-100 disabled:resize-none disabled:border-0 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                    type="text"
                    placeholder=""
                    autoFocus
                    value={replyContent}
                    onKeyDown={(e) => {
                      if (e.key === "Enter") replyCommnet(props.item.id);
                    }}
                    onChange={(e) => setReplyContent(e.target.value)}
                  />
                  <TooltipHorizon
                    trigger={
                      <button onClick={() => replyCommnet(props.item.id)}>
                        <MdSend className="h-6 w-5 text-customcolor-500" />
                      </button>
                    }
                    content={
                      <p className="font-bold text-customcolor-500">Send</p>
                    }
                    placement="top"
                  />
                </div>
              </div>
            </div>
          </div>
        )}
      </div>
    </>
  );
}
