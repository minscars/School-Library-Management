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
import { Modal } from "react-responsive-modal";
import CircularProgress from "@mui/material/CircularProgress";
import Backdrop from "@mui/material/Backdrop";
import {
  MdCheckCircle,
  MdCancel,
  MdOutlineError,
  MdHistory,
} from "react-icons/md";
const History = () => {
  const [openLoader, setOpenLoader] = useState(false);
  const [open, setOpen] = useState(false);
  const onOpenModal = () => setOpen(true);
  const onCloseModal = () => {
    setOpen(false);
    setBookDetailCode("");
    setUserCode("");
  };
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [requestList, setRequestList] = useState([]);
  const navigate = useNavigate();
  const [page, setPage] = useState(0);
  const [limit] = useState(9);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  const [searchText, setSearchText] = useState("");
  const [trigger, setTrigger] = useState();

  useEffect(() => {
    getAllBookRequestFromReact();
  }, [page, limit, searchText, trigger]);

  const getAllBookRequestFromReact = async () => {
    var request = { page, limit };
    if (searchText !== "") {
      request.search = searchText;
    }
    setIsLoaded(false);
    const response = await bookRequestApi.GetAll(request);
    setPageCount(Math.ceil(response?.totalRecord / limit));
    setRequestList(response?.data);
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
  const [bookDetailCode, setBookDetailCode] = useState("");
  const [userCode, setUserCode] = useState("");
  const createNewRequest = async () => {
    var dto = { bookDetailCode, userCode };
    if (bookDetailCode === "" || userCode === "") {
      toast.error("You must fill fully!");
    } else {
      setOpenLoader(true);
      await bookRequestApi.AdminCreateBookRequest(dto).then((res) => {
        if (res.statusCode === 200) {
          setTimeout(() => {
            setOpenLoader(false);

            toast.success(res.message);
            onCloseModal();
          }, 2200);
        } else {
          setTimeout(() => {
            setOpenLoader(false);

            toast.error(res.message);
            onCloseModal();
          }, 2200);
        }
      });
    }
  };
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
                  <option value={2}>Pending</option>
                  <option value={3}>Approved</option>
                  <option value={4}>Borrowing</option>
                  <option value={5}>Returned</option>
                  <option value={7}>Cancled</option>
                </select>
              </div>
            </div>

            <div class="flex text-navy-700 dark:text-white">
              <div className="flex items-center rounded-[5px] bg-gray-100">
                <input
                  type="text"
                  value={searchText}
                  onChange={(e) => setSearchText(e.target.value)}
                  placeholder="Enter a code..."
                  className="flex h-12 w-[360px] w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                />
                <p className="pl-3 pr-2 text-xl">
                  <FiSearch className="h-5 w-5 text-gray-400 dark:text-white" />
                </p>
              </div>
              <button
                onClick={onOpenModal}
                class="linear right-0 ml-6 rounded-[5px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
              >
                + New request
              </button>
            </div>
          </div>
          <div className="mt-2 block h-[530px]">
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
                            moment(row.dueTime, "YYYY-MM-DDTHH:mm:ss.SSSZ")
                          ) &&
                            (row.status === "Approve" ||
                              row.status === "Borrowing" ||
                              row.status === "Cancel" ||
                              row.status === "Rejected") &&
                            "Expired"}
                        </p>
                        {row.status === "Returned" && (
                          <MdCheckCircle className="ml-3 text-green-500" />
                        )}
                      </div>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </Card>
      </div>
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={openLoader}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
      <Pagination
        handlePageClick={handlePageClick}
        currentPage={currentPage}
        pageCount={pageCount}
      />
      <Modal
        open={open}
        onClose={onCloseModal}
        center
        classNames={{
          modal:
            "rounded-[10px] bg-white bg-clip-border shadow-3xl shadow-shadow-500 dark:!bg-navy-800 dark:text-white dark:shadow-none",
        }}
      >
        <div className="h-fit w-[600px]">
          <div className="flex justify-center">
            <span className="text-xl font-bold text-navy-700 dark:text-white">
              Create new request
            </span>
          </div>
          <div class="mb-[10px] mt-2 h-px bg-gray-300 dark:bg-white/30" />
          <div>
            {/* <div className="mt-4"> */}
            <div className="mb-2">
              <label class="text-m text-gray-600 dark:text-white">
                Book code
              </label>
              <input
                className={`mt-2 h-12 w-full justify-center border border-gray-400 bg-white/0 p-3 text-sm outline-none`}
                autoFocus
                value={bookDetailCode}
                onChange={(e) => setBookDetailCode(e.target.value)}
                placeholder="Enter book code"
                type="text"
              />
            </div>
            <div>
              <label class="text-m text-gray-600 dark:text-white">
                Reader code
              </label>
              <input
                className={`mt-2 h-12 w-full justify-center border border-gray-400 bg-white/0 p-3 text-sm outline-none`}
                autoFocus
                value={userCode}
                onChange={(e) => setUserCode(e.target.value)}
                placeholder="Enter reader code"
                type="text"
              />
            </div>
            <button
              onClick={createNewRequest}
              className="linear mt-[60px] flex w-full items-center justify-center rounded-[10px] bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
            >
              Create
            </button>
            {/* </div> */}
          </div>
        </div>
      </Modal>
    </div>
  );
};
export default History;
