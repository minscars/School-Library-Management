import Card from "components/card";
import React, { useState, useEffect, useRef } from "react";
import { useForm } from "react-hook-form";
import { Link } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import { useParams } from "react-router-dom";
import { MdArrowBackIos } from "react-icons/md";
import Alert from "components/alert";
import moment from "moment";
import blogApi from "api/blogApi";
import userAccountAPI from "api/accountApi";
import commentApi from "api/commentApi";
import jwt from "jwt-decode";
import Comment from "./components/comment";
export function Detail() {
  const [post, setPost] = useState([]);
  const { id } = useParams();
  const [trigger, setTrigger] = useState();

  //get current user login
  const [user, setUser] = useState(null);
  const userLogin = jwt(window.localStorage.getItem("token"));

  const [commentList, setComments] = useState([]);
  const { register, handleSubmit, reset } = useForm();
  const formRef = useRef(null);
  useEffect(() => {
    const getbyid = async () => {
      const data = await blogApi.GetById(id);
      setPost(data);
    };
    getbyid();

    const getUser = async () => {
      const user = await userAccountAPI.GetUserAccount(userLogin.id);
      setUser(user);
    };
    getUser();

    const getCommnet = async () => {
      await commentApi.GetCommentPost(id).then((res) => {
        if (res.statusCode === 200) {
          setComments(res.data);
        } else {
          setComments(res.data);
        }
      });
    };
    getCommnet();
  }, [trigger]);

  const addComment = async (content) => {
    const formData = new FormData();
    formData.append("BlogId", id);
    formData.append("UserAccountId", userLogin.id);
    formData.append("Content", content.content);
    await commentApi.CreateCommnet(formData).then(async (res) => {
      if (res.statusCode === 200) {
        setTrigger(Math.random() + 1)
          ?.toString(36)
          .substring(7);
        Alert.showSuccessAlert("Your post have been posted sucessfully!");

        if (formRef.current) {
          formRef.current.reset();
        }
      }
    });
  };

  return (
    <div className="gap-5 xl:grid-cols-2">
      <Card extra={"w-full h-auto px-6 pb-6"}>
        <div className="mb-5 mt-5 flex h-full w-full ">
          <Link to={"/user/forum"}>
            <MdArrowBackIos className="mr-2 " />
          </Link>
          <div className="">
            <div className="flex items-center gap-2">
              <img
                src={post?.avatar}
                className={` h-[42px] w-[42px] rounded-full`}
              />

              <div className="ml-2">
                <p
                  className={` text-m font-bold text-navy-700 dark:text-white`}
                >
                  {post?.userName}
                </p>
                <p className="text-sm font-medium text-navy-700 dark:text-white">
                  {moment(post?.createdDate).format("DD/MM/YYYY")}
                </p>
              </div>
            </div>
            <div className="flex w-full justify-center">
              {/* <img src={image1} className="border-1 h-[260px] w-auto " /> */}
            </div>
            <div className="mt-4">
              <p className="text-[22px] font-bold text-navy-700">
                {post?.title}
              </p>
              <p className="mr-4 mt-2 text-justify text-base text-gray-900">
                <div dangerouslySetInnerHTML={{ __html: post?.content }} />
              </p>
            </div>
            <ToastContainer />
          </div>
        </div>
        <div class="mb-4 h-px bg-gray-300 dark:bg-white/30" />
        <div className="flex flex-col items-center justify-center">
          <span className="align-center mb-3 text-[20px] font-bold text-customcolor-500">
            Comments
          </span>
          <div className="w-full">
            <form ref={formRef} onSubmit={handleSubmit(addComment)}>
              <div className="flex w-full items-center justify-center rounded-[10px] bg-clip-border shadow-3xl shadow-shadow-500 dark:!bg-navy-800 dark:text-white dark:shadow-none">
                <img
                  src={user?.avatar}
                  className="ml-3 mr-3 h-[35px] w-[35px] rounded-full"
                  alt=""
                />
                <input
                  className="autofocus placeholder-shown:border-blue-gray-200 disabled:bg-blue-gray-50 focus:border-1 linear mb-2 mr-3 mt-2 w-[800px] resize-none rounded-[10px] rounded-[7px] bg-lightPrimary px-3 px-4 py-2 py-2.5 font-sans text-sm font-medium font-normal outline-0 transition transition-all duration-200 hover:bg-gray-100 focus:outline-0 active:bg-gray-200 disabled:resize-none disabled:border-0 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                  type="text"
                  placeholder="Let's share about this blog!"
                  autoFocus
                  {...register("content")}
                />
                <button
                  type="submit"
                  className="linear ml-2 cursor-pointer rounded-[10px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
                >
                  Send
                </button>
              </div>
            </form>
            {/* {commentList !== null && (
              <div className="mb-4 ml-4 mt-2 text-[18px] font-bold  text-navy-700">
                <span>All commnents (1)</span>
              </div>
            )} */}
            <div className="table-wrp mt-2 block h-[400px] overflow-x-scroll">
              {commentList === null && (
                <div className="flex flex-col items-center justify-center">
                  <p className="mb-48 mt-5 font-medium text-gray-700">
                    Do not have comment yet!
                  </p>
                </div>
              )}
              <div className="h-[400px]">
                {commentList?.map((row, key) => (
                  <div
                  //className={`mb-1 mt-1 flex w-full items-center justify-between bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none`}
                  >
                    <Comment
                      setTrigger={setTrigger}
                      userId={userLogin.id}
                      blogId={id}
                      item={row}
                    />
                  </div>
                ))}
              </div>
            </div>
          </div>
        </div>
      </Card>
    </div>
  );
}

export default Detail;
