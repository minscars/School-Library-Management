import Card from "components/card";
import { useEffect, useState } from "react";
import jwt from "jwt-decode";
import moment from "moment";
import { Link } from "react-router-dom";
import { FiSearch } from "react-icons/fi";
import "swiper/css";
import "swiper/css/free-mode";
import "swiper/css/scrollbar";
import "./components/scrollContainer/stylesScroll.css";
import bookRequestApi from "api/bookRequest";
import Pagination from "components/pagination";
import { ToastContainer, toast } from "react-toastify";
import { useNavigate } from "react-router-dom";
const History = () => {
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [requestList, setRequestList] = useState([]);
  const navigate = useNavigate();
  const [page, setPage] = useState(0);
  const [limit] = useState(8);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  useEffect(() => {
    getAllBookRequestFromReact();
  }, [page, limit]);

  const getAllBookRequestFromReact = async () => {
    var request = { page, limit };
    setIsLoaded(false);
    const response = await bookRequestApi.GetAll(request);
    setPageCount(Math.ceil(response.totalRecord / limit));
    setRequestList(response.data);
    setIsLoaded(true);
  };

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setPage(e.selected);
  };

  async function handleFilter(e) {
    e.preventDefault();
    var key = e.target.value;
    var request = { page, limit, key };
    if (e.target.value != 0) {
      const response = await bookRequestApi.GetAll(request);
      if (response) {
        setPageCount(Math.ceil(response.totalRecord / limit));
        setRequestList(response.data);
      } else {
        toast.error("Book request status is empty!");
        navigate("/admin/history");
      }
    } else {
      const response = await bookRequestApi.GetAll(request);
      setPageCount(Math.ceil(response.totalRecord / limit));
      setRequestList(response.data);
    }
  }
  return (
    <div>
      <div className="gap-5 xl:grid-cols-2">
        <ToastContainer />
        <Card extra={"w-full px-6 pb-6"}>
          <div class="relative flex items-center justify-between pt-4 ">
            <div className="flex items-center">
              <div class="text-xl font-bold text-navy-700 dark:text-white">
                Requests List
              </div>
              <div>
                <select
                  onChange={(e) => handleFilter(e)}
                  class="ml-4 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                >
                  <option value={0}>All request</option>
                  <option value={1}>Pending</option>
                  <option value={2}>Approved</option>
                  <option value={3}>Borrowing</option>
                  <option value={4}>Returned</option>
                </select>
              </div>
            </div>

            <div className="flex items-center">
              <p className="pl-3 pr-2 text-xl">
                <FiSearch className="h-5 w-5 text-gray-400 dark:text-white" />
              </p>
              <form action="" className="mb-0">
                <input
                  type="text"
                  placeholder="Enter a code..."
                  className="flex h-12 w-[360px] w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                />
              </form>
            </div>
          </div>
          <div className="mt-2 block h-[570px]">
            <table className=" w-full">
              <thead className="sticky top-0 bg-white">
                <tr>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="items-center text-xs uppercase tracking-wide text-gray-600">
                      #id
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="ml-6 text-xs uppercase tracking-wide text-gray-600">
                      create date
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      due date
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[60px] text-start dark:!border-navy-700">
                    <p className="text-xs uppercase tracking-wide text-gray-600">
                      by user
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[60px] text-start dark:!border-navy-700">
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
              <tbody className="">
                {requestList?.map((row) => (
                  <tr
                    key={row.id}
                    className="items-center border-b-2 hover:bg-gray-100"
                  >
                    <td className="mr-6 items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <p className="font-bold text-navy-700 dark:text-white">
                        <Link to={`./detail/${row.id}`}>{row.code}</Link>
                      </p>
                    </td>
                    <td className="items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="ml-6 w-[200px]">
                        {row.createdTime != null
                          ? moment(row.createdTime).format("DD/MM/YYYY HH:mm A")
                          : "......"}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[200px]">
                        {row.dueTime != null
                          ? moment(row.dueTime).format("DD/MM/YYYY")
                          : "......"}
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[200px]">{row.userName}</div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[40px]">
                        <p className="text-sm font-bold text-navy-700 dark:text-white">
                          {row.status}
                        </p>
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[40px]">
                        <p className="text-sm font-bold text-red-500 dark:text-white">
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
      </div>
      <Pagination
        handlePageClick={handlePageClick}
        currentPage={currentPage}
        pageCount={pageCount}
      />
    </div>
  );
};
export default History;
