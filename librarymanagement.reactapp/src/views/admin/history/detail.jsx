import Card from "components/card";
import bookRequestApi from "api/bookRequest";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

import "react-toastify/dist/ReactToastify.css";
import banner from "assets/img/profile/banner.png";
import moment from "moment";
import Button from "@mui/material/Button";
import HorizontalNonLinearStepper from "./components/stepper";
function Detail() {
  const [bookRequest, setBookRequest] = useState([]);
  const { id } = useParams();
  const [trigger, setTrigger] = useState();
  const [open, setOpen] = useState(false);
  const handleClose = () => {
    setOpen(false);
  };
  const handleOpen = () => {
    setOpen(true);
  };
  useEffect(() => {
    const getbyid = async () => {
      const data = await bookRequestApi.GetDetail(id);
      setBookRequest(data);
    };
    getbyid();
  }, [trigger]);

  const checkExpired = async () => {
    try {
      if (
        moment().isAfter(
          moment(bookRequest.dueTime, "YYYY-MM-DDTHH:mm:ss.SSSZ")
        ) &&
        (bookRequest.status === "Approve" ||
          bookRequest.status === "Borrowing" ||
          bookRequest.status === "Cancel")
      ) {
        var bookRequestId = id;
        const request = { bookRequestId };
        request.status = 6;
        request.bookDetailId = bookRequest.bookDetailId;
        request.publishedBookId = bookRequest.publishedBookId;

        const res = await bookRequestApi.UpdateStatus(request);
      }
    } catch (error) {
      console.error("Error in checkExpired:", error);
      // Handle error, show an alert or update state accordingly
    }
  };

  useEffect(() => {
    checkExpired();
  }, [bookRequest]);

  return (
    <div className="mt-3 grid h-fit grid-cols-1 gap-5 ">
      <div className="col-span-1 h-full w-full rounded-xl 2xl:col-span-2">
        <Card extra={"w-full p-4 h-[650px]"}>
          <div className="flex h-fit w-full items-center justify-between rounded-t-2xl bg-white px-4 pb-[20px] pt-4 shadow-2xl shadow-gray-100 dark:!bg-navy-700 dark:shadow-none">
            <h4 className=" text-lg font-bold text-navy-700 dark:text-white">
              Request ID:
              <span className="ml-2 font-bold text-blue-700">
                {bookRequest.code}{" "}
              </span>
              {moment().isAfter(
                moment(bookRequest.dueTime, "YYYY-MM-DDTHH:mm:ss.SSSZ")
              ) &&
                (bookRequest.status === "Approve" ||
                  bookRequest.status === "Borrowing" ||
                  bookRequest.status === "Cancel" ||
                  bookRequest.status === "Rejected") && (
                  <span className="ml-2 text-red-500">(Expired)</span>
                )}
            </h4>
            <div className="float-right mr-2">
              <p className="float-right font-bold text-navy-700 dark:text-white">
                Status:{" "}
                <span className="font-bold text-blue-700">
                  {bookRequest.status}
                </span>
              </p>
            </div>
          </div>
          <div className="flex">
            <div className="mr-6 mt-3 flex w-full items-center justify-between rounded-2xl bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none">
              <div className="flex">
                <div>
                  <img
                    className="h-[250px] w-full rounded-lg border-2"
                    src={bookRequest.publishedBookImage}
                    alt=""
                  />
                </div>
                <div className="ml-4">
                  <p className="mr-20 text-lg font-bold text-navy-700 dark:text-white">
                    {bookRequest.publishedBookName}
                  </p>
                  <p className="mt-2 text-gray-600">
                    <b>Code book taked:</b>{" "}
                    <span className="mr-20 font-bold text-navy-700 dark:text-white">
                      {bookRequest.bookDetailCode}
                    </span>
                  </p>
                  <p className="mt-2 text-gray-600">
                    {" "}
                    <b>Quantity:</b> 1
                  </p>
                </div>
              </div>
            </div>
            <div className="mt-3 w-[600px] rounded-xl">
              <Card extra={"w-full p-4"}>
                {/* Background and profile */}
                <div
                  className="relative mt-1 flex h-[100px] w-full justify-center rounded-xl bg-cover"
                  style={{ backgroundImage: `url(${banner})` }}
                >
                  <div className="absolute -bottom-12 flex h-[100px] w-[100px] items-center justify-center rounded-full border-[4px] border-white bg-pink-400 dark:!border-navy-700">
                    <img
                      className="h-full w-full rounded-full"
                      src={bookRequest?.userAvatar}
                      alt="user avatar"
                    />
                  </div>
                </div>

                {/* Name and position */}
                <div className="mt-16 flex flex-col items-center">
                  <h4 className="text-xl font-bold text-navy-700 dark:text-white">
                    {bookRequest?.userName}
                  </h4>
                  <p className="text-base font-normal text-gray-600">Reader</p>
                </div>

                {/* Post followers */}
                <div className="mr-4 mt-4 text-gray-600 dark:text-white">
                  <div>
                    UserCode:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {bookRequest?.userCode} <br />
                    </span>
                  </div>
                  <div>
                    Email:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {bookRequest?.userEmail} <br />
                    </span>
                  </div>
                  <div>
                    Phone number:{" "}
                    <span className="mr-2 mt-2 text-base font-normal text-gray-800 dark:text-white">
                      {bookRequest?.userPhone}
                    </span>
                  </div>
                  <div>
                    Address:{" "}
                    <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
                      {bookRequest?.userAddress}
                    </span>
                  </div>
                </div>
              </Card>
            </div>
          </div>
          {bookRequest?.status !== "Cancel" &&
            bookRequest?.status !== "Rejected" && (
              <div>
                <p className="mb-6 mt-6 font-medium text-blue-700 dark:text-white">
                  <b>Confirm request</b>
                </p>
                <div>
                  <HorizontalNonLinearStepper
                    setTrigger={setTrigger}
                    data={bookRequest}
                  />
                </div>
              </div>
            )}
          {bookRequest?.status === "Cancel" && (
            <div>
              <p className="mb-6 mt-6 text-[16px] font-normal text-blue-700 dark:text-white">
                <b>*Note: </b>
                <span className="text-red-700">
                  {" "}
                  This request has been canceled at{" "}
                  {moment(bookRequest?.canceledTime).format(
                    "DD/MM/YYYY HH:mm"
                  )}{" "}
                  by {bookRequest?.userName}
                </span>
              </p>
            </div>
          )}

          {bookRequest?.status === "Rejected" && (
            <div>
              <p className="mb-6 mt-6 text-[16px] font-normal text-blue-700 dark:text-white">
                <b>*Note: </b>
                <span className="text-red-700">
                  {" "}
                  This request has been rejected at{" "}
                  {moment(bookRequest?.rejectedTime).format(
                    "DD/MM/YYYY HH:mm"
                  )}{" "}
                  because {bookRequest?.userName} does not take this book on
                  time!
                </span>
              </p>
            </div>
          )}
        </Card>
      </div>
      <div></div>
    </div>
  );
}

export default Detail;
