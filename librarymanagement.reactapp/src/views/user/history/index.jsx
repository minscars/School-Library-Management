import Card from "components/card";
import { useEffect, useState } from "react";
import jwt from "jwt-decode";
import moment from "moment";
import { Link } from "react-router-dom";
import bookRequestApi from "api/bookRequest";
import Pagination from "components/pagination";
const History = () => {
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [requestList, setRequestList] = useState([]);
  const [page, setPage] = useState(0);
  const [limit] = useState(4);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  useEffect(() => {
    getAllBookRequestFromReact();
  }, [page, limit]);
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
                    <p className="ml-4 items-center text-xs uppercase tracking-wide text-gray-600">
                      # id request
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700"></th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      create date
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      due time
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      status
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      note
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
                      <p className="font-bold text-navy-700 dark:text-white">
                        <Link to={`./detail/${row.id}`}>{row.code}</Link>
                      </p>
                    </td>
                    <td className="items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <img
                        src={row.publishedBookImage}
                        alt=""
                        className="ml-4 h-[90px] w-auto rounded-xl border-2 3xl:h-full 3xl:w-full"
                      />
                    </td>
                    <td className=" items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className=" w-[240px]">
                        {row.createdTime != null
                          ? moment(row.createdTime).format("DD/MM/YYYY HH:mm A")
                          : "..."}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[240px]">
                        {row.dueTime != null
                          ? moment(row.dueTime).format("DD/MM/YYYY")
                          : "..."}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[40px]">
                        <p className="font-bold text-navy-700 dark:text-white">
                          {row.status}
                        </p>
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[40px]">
                        <p className="font-bold text-red-500 dark:text-white">
                          {moment().isAfter(
                            moment(row.dueDate, "YYYY-MM-DDTHH:mm:ss.SSSZ")
                          ) &&
                            (row.status === "Approve" ||
                              row.status === "Borrowing" ||
                              row.status === "Cancel") &&
                            "Expired"}
                        </p>
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
