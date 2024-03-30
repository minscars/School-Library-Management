import Card from "components/card";
import bookRequestApi from "api/bookRequest";
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import "react-toastify/dist/ReactToastify.css";
import banner from "assets/img/profile/banner.png";
import moment from "moment";
import Alert from "components/alert";
import Swal from "sweetalert2";
function Detail() {
  const [bookRequest, setBookRequest] = useState([]);
  const { id } = useParams();
  useEffect(() => {
    const getbyid = async () => {
      const data = await bookRequestApi.GetDetail(id);
      setBookRequest(data);
    };
    getbyid();
  }, []);

  const handleUpdateStatus = async (status) => {
    Swal.fire({
      title: "Are you sure?",
      input: "text",
      text: "You should recheck the user information before update status!",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, I checked it!",
    }).then(async (result) => {
      if (result.isConfirmed) {
        var bookRequestId = bookRequest.id;
        const request = { bookRequestId, status };
        if (status === 3) {
          request.bookTaked = result.value;
        }
        if (status === 4) {
          request.bookTaked = bookRequest.bookTaked;
        }
        //alert(request);
        request.comment = result.value;
        console.log(request.bookTaked);
        console.log(status);

        await bookRequestApi.UpdateStatus(request).then(async (res) => {
          console.log(request);
          if (res.statusCode === 200) {
            Alert.showSuccessAlert("Update status sucessfully!");
            const data = await bookRequestApi.GetDetail(id);
            setBookRequest(data);
          } else {
            Alert.showErrorAlert("Something went worong!");
          }
        });
      }
    });
  };

  return (
    <div className="mt-3 grid h-full grid-cols-1 gap-5 xl:grid-cols-2 2xl:grid-cols-3">
      <div className="col-span-1 h-full w-full rounded-xl 2xl:col-span-2">
        <Card extra={"w-full p-4 h-[600px]"}>
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
                  bookRequest.status === "Cancel") && (
                  <span className="ml-2 text-red-500">(Expired)</span>
                )}
            </h4>
            <div className="float-right mr-2">
              {bookRequest.status === "Pending" && (
                <button
                  onClick={() => handleUpdateStatus(2)}
                  class="linear ml-2 rounded-[20px] bg-lightPrimary px-4 py-2 text-sm font-medium text-blue-500 transition duration-200 hover:bg-gray-100 active:bg-gray-200 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                >
                  Approve
                </button>
              )}
              {bookRequest.status === "Pending" && (
                <button
                  onClick={() => handleUpdateStatus(5)}
                  class="linear ml-2 rounded-[20px] bg-lightPrimary px-4 py-2 text-sm font-medium text-orange-500 transition duration-200 hover:bg-gray-100 active:bg-gray-200 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                >
                  Rejected
                </button>
              )}
              {bookRequest.status === "Approve" && (
                <div>
                  <button
                    onClick={() => handleUpdateStatus(3)}
                    class="linear ml-2 rounded-[20px] bg-lightPrimary px-4 py-2 text-sm font-medium text-brand-500 transition duration-200 hover:bg-gray-100 active:bg-gray-200 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                  >
                    Received
                  </button>
                  <button
                    onClick={() => handleUpdateStatus(6)}
                    class="linear ml-2 rounded-[20px] bg-lightPrimary px-4 py-2 text-sm font-medium text-red-600 transition duration-200 hover:bg-gray-100 active:bg-gray-200 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                  >
                    Cancel
                  </button>
                </div>
              )}
              {(bookRequest.status === "Received" ||
                bookRequest.status === "Borrowing") && (
                <button
                  onClick={() => handleUpdateStatus(4)}
                  class="linear ml-2 rounded-[20px] bg-lightPrimary px-4 py-2 text-sm font-medium text-lime-600 transition duration-200 hover:bg-gray-100 active:bg-gray-200 dark:bg-white/5 dark:text-white dark:hover:bg-white/10 dark:active:bg-white/20"
                >
                  Returned
                </button>
              )}
            </div>
          </div>
          <div className=" mt-2">
            <div className="float-right mr-20 flex flex-col">
              <p className="float-right font-bold text-navy-700 dark:text-white">
                Status:{" "}
                <span className="font-bold text-blue-700">
                  {bookRequest.status}
                </span>
              </p>

              <p className="float-right mt-2 font-bold text-navy-700 dark:text-white">
                Available:{" "}
                <span className="font-bold text-blue-700">
                  {bookRequest.available}
                </span>
              </p>
            </div>
          </div>
          <div className="mt-3 flex w-full items-center justify-between rounded-2xl bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none">
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
                    {bookRequest.bookTaked}
                  </span>
                </p>
                <p className="mt-2 text-gray-600">
                  {" "}
                  <b>Quantity:</b> 1
                </p>
              </div>
            </div>
          </div>
          <p className="mb-1 mt-3 font-medium text-blue-700 dark:text-white">
            <b>*Note:</b> {bookRequest.comment}
          </p>
        </Card>
      </div>
      <div className="col-span-1 w-full rounded-xl 2xl:col-span-1">
        <Card extra={"w-full p-4"}>
          {/* Background and profile */}
          <div
            className="relative mt-1 flex h-32 w-full justify-center rounded-xl bg-cover"
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
            Email:{" "}
            <span className="mr-2 text-base font-normal text-gray-800 dark:text-white">
              {bookRequest?.email} <br />
            </span>
            Phone number:{" "}
            <span className="mr-2 mt-2 text-base font-normal text-gray-800 dark:text-white">
              {bookRequest?.phoneNumber}
            </span>
          </div>
        </Card>
        <div>
          <div className="ml-4 mt-4 flex items-center justify-between">
            <p className="font-bold text-navy-700 dark:text-white">
              Create date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.createdTime != null
                  ? moment(bookRequest.createdTime).format("DD/MM/YYYY HH:mm A")
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Rejected date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.rejectedDate != null
                  ? moment(bookRequest.rejectedDate).format(
                      "DD/MM/YYYY HH:mm A"
                    )
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Approval date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.approvedTime != null
                  ? moment(bookRequest.approvedTime).format(
                      "DD/MM/YYYY HH:mm A"
                    )
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Borrow date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.borrowedTime != null
                  ? moment(bookRequest.borrowDate).format("DD/MM/YYYY HH:mm A")
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Received date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.receivedTime != null
                  ? moment(bookRequest.receivedDate).format(
                      "DD/MM/YYYY HH:mm A"
                    )
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Due date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.dueTime != null
                  ? moment(bookRequest.dueTime).format("DD/MM/YYYY")
                  : "..."}
              </span>
            </p>
          </div>
          <div className="ml-4 mt-4">
            <p className="font-bold text-navy-700 dark:text-white">
              Returned date:{" "}
              <span className="font-bold text-blue-700">
                {bookRequest.returnedTime != null
                  ? moment(bookRequest.dueDate).format("DD/MM/YYYY")
                  : "..."}
              </span>
            </p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Detail;
