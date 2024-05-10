import Card from "components/card";
import bookRequestApi from "api/bookRequest";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import "react-toastify/dist/ReactToastify.css";
import banner from "assets/img/profile/banner.png";
import Alert from "components/alert";
import Swal from "sweetalert2";
import CircularProgress from "@mui/material/CircularProgress";
import Backdrop from "@mui/material/Backdrop";
import Stepper from "./component/stepper/index";
// import HorizontalNonLinearStepper from "./components/stepper";
import blogApi from "api/blogApi";
function Detail() {
  const { id } = useParams();
  const [trigger, setTrigger] = useState();
  const [blog, setBlog] = useState();
  useEffect(() => {
    const getDetailBlog = async () => {
      const data = await blogApi.GetById(id);
      setBlog(data);
    };
    getDetailBlog();
  }, [trigger, id]);
  const [open, setOpen] = useState(false);
  const handleUpdateStatus = () => {
    Swal.fire({
      title: "Are you sure?",
      text: "You should recheck the user information before update status!",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, I checked it!",
    }).then(async (result) => {
      if (result.isConfirmed) {
        var blogId = blog.id;
        var status = 3;
        var dto = { blogId, status };
        console.log(dto);
        setOpen(true);
        await blogApi.UpdateStatusBlog(dto).then(async (res) => {
          if (res.statusCode === 200) {
            setTimeout(() => {
              setOpen(false);
              setTrigger(Math.random() + 1)
                ?.toString(36)
                .substring(7);
              Alert.showSuccessAlert("Update status sucessfully!");
            }, 2200);
          } else {
            setTimeout(() => {
              setOpen(false);
              setTrigger(Math.random() + 1)
                ?.toString(36)
                .substring(7);

              Alert.showErrorAlert("Something went worong!");
            }, 2200);
          }
        });
      }
    });
  };
  return (
    <div className="grid h-fit grid-cols-1 gap-5 ">
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={open}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
      <div className="col-span-1 h-full w-full rounded-xl 2xl:col-span-2">
        <Card extra={"w-full p-4 h-[650px]"}>
          <div className="flex h-fit w-full items-center justify-between rounded-t-2xl bg-white px-4 pb-[20px] pt-4 shadow-2xl shadow-gray-100 dark:!bg-navy-700 dark:shadow-none">
            <h4 className=" text-lg font-bold text-navy-700 dark:text-white">
              Request ID:
              <span className="ml-2 font-bold text-blue-700">{blog?.id}</span>
            </h4>
            <div className="float-right mr-2">
              <p className="float-right font-bold text-navy-700 dark:text-white">
                Status:{" "}
                <span className="font-bold text-blue-700">{blog?.status}</span>
              </p>
            </div>
          </div>
          <div className="flex">
            <div className="mr-6 mt-3 h-fit w-full rounded-2xl bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none">
              <div className="flex items-center">
                <h4 className=" text-lg font-bold text-navy-700 dark:text-white">
                  {" "}
                  Title:
                </h4>
                <span className="ml-2 font-bold text-blue-700">
                  {blog?.title}
                </span>
              </div>
              <h4 className=" text-lg font-bold text-navy-700 dark:text-white">
                {" "}
                Content:
              </h4>
              <div className="h-[470px] overflow-x-scroll">
                <p className="mr-4 mt-2 text-justify text-gray-900">
                  <div dangerouslySetInnerHTML={{ __html: blog?.content }} />
                </p>
              </div>
            </div>
            <div className="mt-3 h-fit w-[600px] rounded-xl">
              {blog?.status !== "Cancel" && (
                <div>
                  <div className="flex items-center">
                    <div>
                      <p className="ml-4 font-medium text-blue-700 dark:text-white">
                        <b>Confirm request</b>
                      </p>
                    </div>
                    {blog?.status === "Pending" && (
                      <div className="ml-[120px]">
                        <button
                          onClick={handleUpdateStatus}
                          class="linear right-0 rounded-[5px] bg-orange-600 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-orange-700 active:bg-orange-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
                        >
                          Cancel
                        </button>
                      </div>
                    )}
                  </div>
                  <div className="ml-10">
                    <Stepper setTrigger={setTrigger} data={blog} />
                  </div>
                </div>
              )}
              <Card extra={"w-full p-4 sticky"}>
                {/* Background and profile */}
                <div
                  className="relative flex h-[60px] w-full justify-center rounded-xl bg-cover"
                  style={{ backgroundImage: `url(${banner})` }}
                >
                  <div className="absolute mt-4 flex  items-center justify-center rounded-full border-[4px] border-white bg-pink-400 dark:!border-navy-700">
                    <img
                      className="h-[90px] w-[90px] rounded-full"
                      src={blog?.avatar}
                      alt="user avatar"
                    />
                  </div>
                </div>

                {/* Name and position */}
                <div className="mt-16 flex flex-col items-center">
                  <h4 className="text-xl font-bold text-navy-700 dark:text-white">
                    {blog?.userName}
                  </h4>
                  <p className="text-base font-normal text-gray-600">Reader</p>
                </div>

                {/* Post followers */}
                <div className="mr-4 mt-4 text-gray-600 dark:text-white">
                  <div>
                    UserCode:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {blog?.userCode} <br />
                    </span>
                  </div>
                  <div>
                    Email:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {blog?.email} <br />
                    </span>
                  </div>
                  <div>
                    Phone number:{" "}
                    <span className="mr-2 mt-2 text-base font-normal text-gray-800 dark:text-white">
                      {blog?.phoneNumber}
                    </span>
                  </div>
                  <div>
                    Address:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {blog?.address}
                    </span>
                  </div>
                </div>
              </Card>
            </div>
          </div>
        </Card>
      </div>
    </div>
  );
}

export default Detail;
