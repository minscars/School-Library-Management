import Card from "components/card";
import { useEffect, useState } from "react";
import jwt from "jwt-decode";
import moment from "moment";
import { Link } from "react-router-dom";
import bookRequestApi from "api/bookRequest";
import Pagination from "components/pagination";
import { FiSettings } from "react-icons/fi";

import {
  MdCheckCircle,
  MdCancel,
  MdOutlineError,
  MdHistory,
} from "react-icons/md";
import TooltipHorizon from "components/tooltip";
import Alert from "components/alert";
import Swal from "sweetalert2";
const History = (props) => {
  const [requestList, setRequestList] = useState([]);
  const [page, setPage] = useState(0);
  const [limit] = useState(7);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  const [trigger, setTrigger] = useState();
  useEffect(() => {
    getAllBookRequestFromReact();
  }, [page, limit, trigger]);

  const getAllBookRequestFromReact = async () => {
    const dto = { page, limit };
    dto.userId = props.userId;
    setIsLoaded(false);
    const response = await bookRequestApi.GetByAccount(dto);
    setPageCount(Math.ceil(response?.totalRecord / limit));
    setRequestList(response?.data);
    setIsLoaded(true);
  };

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setPage(e.selected);
  };

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
    if (status === 8) {
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
        <Card extra={"w-full sm:overflow-x-auto"}>
          <div class="mt-2 block h-[540px]">
            {requestList === undefined && (
              <div className="flex flex-col items-center justify-center">
                <p className="mt-20 text-xl text-gray-700">Request is empty!</p>
              </div>
            )}
            {requestList !== undefined && (
              <table className="w-full">
                <thead>
                  <tr>
                    <th className="pr-30 border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                      <p className="items-center text-xs uppercase tracking-wide text-gray-600">
                        # book code
                      </p>
                    </th>
                    <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                      <p className="text-xs uppercase tracking-wide text-gray-600">
                        name
                      </p>
                    </th>
                    <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                      <p className="text-xs uppercase tracking-wide text-gray-600">
                        created time
                      </p>
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
                      <p className="ml-2 text-xs uppercase tracking-wide text-gray-600"></p>
                    </th>
                  </tr>
                </thead>
                <tbody>
                  {requestList?.map((row) => (
                    <tr
                      key={row.id}
                      className="items-center border-b-2 hover:bg-gray-100"
                    >
                      <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className=" w-[130px]">
                          <p className=" font-bold text-customcolor-500 dark:text-white">
                            {row.bookDetailCode}
                          </p>
                        </div>
                      </td>
                      <td className="items-center pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className=" w-[200px]">
                          {row.publishedBookName}
                        </div>
                      </td>
                      <td className=" items-center pb-[15px] pt-[14px] sm:text-[15px]">
                        <div className=" w-[130px]">
                          {row.createdTime !== null
                            ? moment(row.createdTime).format(
                                "DD/MM/YYYY HH:mm "
                              )
                            : "..."}
                        </div>
                      </td>
                      <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className=" w-[100px]">
                          {row.borrowedTime !== null
                            ? moment(row.borrowedTime).format("DD/MM/YYYY")
                            : "..."}
                        </div>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className="w-[100px]">
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
                        <div className="ml-4 w-[60px] items-center">
                          {row.status === "Pending" && (
                            <p className="hover:text-black flex cursor-pointer items-center gap-2 pt-1 text-red-500 hover:font-medium">
                              <TooltipHorizon
                                trigger={
                                  <button className="ml-6">
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
                          {row.status === "Cancel" &&
                            (row.canceledTime !== null
                              ? moment(row.canceledTime).format("DD/MM/YYYY ")
                              : "...")}
                          {row.status === "Returned" && (
                            <MdCheckCircle className="ml-6 text-green-500" />
                          )}

                          {row.status === "Borrowing" && (
                            <p className="hover:text-black flex cursor-pointer items-center gap-2 pt-1 text-customcolor-500 hover:font-medium">
                              <span>
                                {/* <MdHistory className="h-5 w-5" /> */}
                                <TooltipHorizon
                                  trigger={
                                    <button className="ml-6">
                                      <MdHistory
                                        onClick={() =>
                                          handleUpdateStatus(8, row)
                                        }
                                        className="h-5 w-5"
                                      />
                                    </button>
                                  }
                                  content={
                                    <p className="text-customcolor-500">
                                      Extend
                                    </p>
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
            )}
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
