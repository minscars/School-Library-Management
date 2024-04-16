import Card from "components/card";
import { useEffect, useState } from "react";
import jwt from "jwt-decode";
import moment from "moment";
import { Link } from "react-router-dom";
import bookRequestApi from "api/bookRequest";
import Pagination from "components/pagination";
import { FiSettings } from "react-icons/fi";
import { MdHistory } from "react-icons/md";
import TooltipHorizon from "components/tooltip";
import Alert from "components/alert";
import Swal from "sweetalert2";
const History = () => {
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [requestList, setRequestList] = useState([]);
  const [page, setPage] = useState(0);
  const [limit] = useState(6);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  const [trigger, setTrigger] = useState();
  useEffect(() => {
    getAllBookRequestFromReact();
  }, [page, limit, trigger]);
  const userId = userLogin.id;

  const getAllBookRequestFromReact = async () => {
    const dto = { page, limit, userId };
    setIsLoaded(false);
    const response = await bookRequestApi.GetByAccount(dto);
    setPageCount(Math.ceil(response.totalRecord / limit));
    setRequestList(response.data);
    setIsLoaded(true);
  };

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setPage(e.selected);
  };
  console.log(requestList);

  const handleUpdateStatus = async (status, row) => {
    if (status === 7) {
      Swal.fire({
        title: "Are you sure?",
        text: "Do you want to cancel this request!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, I want it!",
      }).then(async (result) => {
        if (result.isConfirmed) {
          var bookRequestId = row?.id;
          var bookDetailId = row?.bookDetailId;
          var publishedBookId = row?.publishedBookId;
          const request = {
            bookRequestId,
            status,
            bookDetailId,
            publishedBookId,
          };

          await bookRequestApi.UpdateStatus(request).then(async (res) => {
            console.log(request);
            if (res.statusCode === 200) {
              setTrigger(Math.random() + 1)
                ?.toString(36)
                .substring(7);
              Alert.showSuccessAlert("Cancel request sucessfully!");
            } else {
              Alert.showErrorAlert("Something went worong!");
            }
          });
        }
      });
    }
    if (status == 8) {
      Swal.fire({
        title: "Are you sure?",
        text: "Do you want to extend this request!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, I want it!",
      }).then(async (result) => {
        if (result.isConfirmed) {
          var bookRequestId = row?.id;
          var bookDetailId = row?.bookDetailId;
          var publishedBookId = row?.publishedBookId;
          const request = {
            bookRequestId,
            status,
            bookDetailId,
            publishedBookId,
          };

          await bookRequestApi.UpdateStatus(request).then(async (res) => {
            console.log(request);
            if (res.statusCode === 200) {
              setTrigger(Math.random() + 1)
                ?.toString(36)
                .substring(7);
              Alert.showSuccessAlert("Extend request sucessfully!");
            } else {
              Alert.showErrorAlert("Something went worong!");
            }
          });
        }
      });
    }
  };
  return (
    <div>
      <div className="gap-5 xl:grid-cols-2">
        <Card extra={"w-full px-6 pb-6 sm:overflow-x-auto"}>
          <div class="relative flex items-center justify-between pt-4">
            <div class="text-xl font-bold text-navy-700 dark:text-white">
              Your request
            </div>
          </div>
          <div class="mt-2 block h-[540px]">
            <table className="w-full">
              <thead>
                <tr>
                  <th className="pr-30 border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="items-center text-xs uppercase tracking-wide text-gray-600">
                      # book code
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      name
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600"></p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      borrow time
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      due time
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      status
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                    <p className="ml-4 text-xs uppercase tracking-wide text-gray-600">
                      action
                    </p>
                  </th>
                </tr>
              </thead>
              <tbody>
                {requestList?.map((row, key) => (
                  <tr
                    key={row.id}
                    className="items-center border-b-2 hover:bg-gray-100"
                  >
                    <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className=" w-[150px]">
                        <p className="font-bold text-navy-700 dark:text-white">
                          {/* <Link to={`./detail/${row.id}`}> */}
                          {row.bookDetailCode}
                          {/* </Link> */}
                        </p>
                      </div>
                    </td>
                    <td className="items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className=" w-[240px]">
                        <p className="font-bold text-navy-700 dark:text-white">
                          {row.publishedBookName}
                        </p>
                      </div>
                    </td>
                    <td className=" items-center pb-[15px] pt-[14px] sm:text-[15px]">
                      <div className=" w-[210px]">
                        <p>
                          <strong>Created: </strong>
                          <span>
                            {row.createdTime !== null
                              ? moment(row.createdTime).format(
                                  "DD/MM/YYYY HH:mm A"
                                )
                              : "..."}{" "}
                          </span>
                        </p>
                        <p className="mt-2 ">
                          <strong>Canceled: </strong>
                          <span>
                            {row.canceledTime !== null
                              ? moment(row.canceledTime).format(
                                  "DD/MM/YYYY HH:mm A"
                                )
                              : "..."}{" "}
                          </span>
                        </p>
                        <p className="mt-2 ">
                          <strong>Extened: </strong>
                          <span>
                            {row.extendedTime !== null
                              ? moment(row.extendedTime).format(
                                  "DD/MM/YYYY HH:mm A"
                                )
                              : "..."}{" "}
                          </span>
                        </p>
                      </div>
                    </td>
                    <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className=" w-[120px]">
                        {row.borrowedTime !== null
                          ? moment(row.borrowedTime).format("DD/MM/YYYY")
                          : "..."}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[130px]">
                        {row.dueTime !== null
                          ? moment(row.dueTime).format("DD/MM/YYYY")
                          : "..."}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[60px]">
                        <p className="font-bold text-navy-700 dark:text-white">
                          {row.status}
                        </p>
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="ml-8 w-[60px] items-center">
                        {/* <p className="font-bold text-red-500 dark:text-white">
                          {moment().isAfter(
                            moment(row.dueDate, "YYYY-MM-DDTHH:mm:ss.SSSZ")
                          ) &&
                            (row.status === "Approve" ||
                              row.status === "Borrowing" ||
                              row.status === "Cancel") &&
                            "Expired"}
                        </p> */}
                        {row.status === "Pending" && (
                          <p className="hover:text-black flex cursor-pointer items-center gap-2 pt-1 text-red-500 hover:font-medium">
                            <TooltipHorizon
                              trigger={
                                <button>
                                  <FiSettings
                                    onClick={() => handleUpdateStatus(7, row)}
                                  />
                                </button>
                              }
                              content={<p className="text-red-500">Cancel</p>}
                              placement="top"
                            />
                          </p>
                        )}

                        {row.status === "Borrowing" && (
                          <p className="hover:text-black flex cursor-pointer items-center gap-2 pt-1 text-customcolor-500 hover:font-medium">
                            <span>
                              {/* <MdHistory className="h-5 w-5" /> */}
                              <TooltipHorizon
                                trigger={
                                  <button>
                                    <MdHistory
                                      onClick={() => handleUpdateStatus(8, row)}
                                      className="h-5 w-5"
                                    />
                                  </button>
                                }
                                content={
                                  <p className="text-customcolor-500">Extend</p>
                                }
                                placement="top"
                              />
                            </span>
                          </p>
                        )}
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </Card>
        <Pagination
          handlePageClick={handlePageClick}
          currentPage={currentPage}
          pageCount={pageCount}
        />
      </div>
    </div>
  );
};
export default History;
