import { MdCancel, MdModeEditOutline } from "react-icons/md";
import Card from "components/card";
import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import cateApi from "../../../api/categoryAPI";
import moment from "moment";
import CircularProgress from "@mui/material/CircularProgress";
import Backdrop from "@mui/material/Backdrop";
import { Modal } from "react-responsive-modal";
import { toast, ToastContainer } from "react-toastify";
const Index = () => {
  const [catesList, setCates] = useState([]);
  const [openLoader, setOpenLoader] = useState(false);
  const [open, setOpen] = useState(false);
  const onOpenModal = () => setOpen(true);
  const onCloseModal = () => {
    setOpen(false);
    setCateName("");
  };
  const [name, setCateName] = useState("");
  const [trigger, setTrigger] = useState();
  useEffect(() => {
    const getall = async () => {
      const data = await cateApi.GetAll();
      setCates(data);
    };
    getall();
  }, [trigger]);
  const createNewCate = async () => {
    setOpen(true);
    await cateApi.Create(name).then((response) => {
      if (response.statusCode === 200) {
        setTimeout(() => {
          setTrigger(Math.random() + 1)
            ?.toString(36)
            .substring(7);
          setOpen(false);
          toast.success(response?.message);
        }, 2200);
      } else {
        setTimeout(() => {
          setOpen(false);
          toast.error(response?.message);
        }, 2200);
      }
    });
  };
  return (
    <div>
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={openLoader}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
      <ToastContainer />
      <div className="gap-5 xl:grid-cols-2">
        <Card extra={"w-full h-[650px] px-6 pb-6"}>
          <div class="relative mb-2 pt-4">
            <div class="flex items-center justify-between text-xl font-bold text-navy-700 dark:text-white">
              <p className="left-0 top-0">Categories List</p>
              <button
                onClick={onOpenModal}
                class="linear right-0 rounded-[5px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
              >
                + New category
              </button>
            </div>
          </div>
          <div className="table-wrp mt-2 block h-[600px] overflow-y-scroll">
            <table className="w-full">
              <thead className="sticky top-0 bg-white">
                <tr>
                  <th className="border-b border-gray-200 pb-[10px] pr-[40px] text-start dark:!border-navy-700">
                    <p className="ml-9 items-center text-xs tracking-wide text-gray-600">
                      #
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">NAME</p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">
                      CREATED TIME
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">
                      UPDATED TIME
                    </p>
                  </th>
                  <th
                    colSpan="3"
                    className="border-b border-gray-200 pb-[10px] pr-28 text-start dark:!border-navy-700"
                  >
                    <p className="text-xs tracking-wide text-gray-600">
                      ACTION
                    </p>
                  </th>
                </tr>
              </thead>
              <tbody className=" overflow-y-auto">
                {catesList.map((row, index) => {
                  return (
                    <tr key={row.id} className="border-b-2 hover:bg-gray-100">
                      <td className="flex items-center justify-center pb-[9px] pt-[9px] sm:text-[15px]">
                        <p className="mr-8 text-sm font-bold text-navy-700 dark:text-white">
                          {index + 1}
                        </p>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[14px]">
                        <p className="text-sm font-bold text-navy-700 dark:text-white">
                          {row.name}
                        </p>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[14px]">
                        <p className="text-sm  text-navy-700 dark:text-white">
                          {row.createdDate != null
                            ? moment(row.createdDate).format(
                                "DD/MM/YYYY HH:mm A"
                              )
                            : "..."}
                        </p>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[14px]">
                        <p className="text-sm text-navy-700 dark:text-white">
                          {row.updatedDate != null
                            ? moment(row.updatedDate).format(
                                "DD/MM/YYYY HH:mm A"
                              )
                            : "..."}
                        </p>
                      </td>
                      <td className="flex items-center gap-2 pb-[18px] pt-[14px] sm:text-[14px]">
                        <Link to={`./edit/${row.id}`}>
                          <MdModeEditOutline className="rounded-full text-xl" />
                        </Link>
                      </td>
                    </tr>
                  );
                })}
              </tbody>
            </table>
          </div>
        </Card>
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
                Create new category
              </span>
            </div>
            <div class="mb-[10px] mt-2 h-px bg-gray-300 dark:bg-white/30" />
            <div>
              {/* <div className="mt-4"> */}
              <div className="mb-2">
                <label class="text-m text-gray-600 dark:text-white">
                  Category name
                </label>
                <input
                  className={`mt-2 h-12 w-full justify-center border border-gray-400 bg-white/0 p-3 text-sm outline-none`}
                  autoFocus
                  value={name}
                  onChange={(e) => setCateName(e.target.value)}
                  placeholder="Enter book code"
                  type="text"
                />
              </div>
              <button
                onClick={createNewCate}
                className="linear mt-[60px] flex w-full items-center justify-center rounded-[10px] bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
              >
                Create
              </button>
              {/* </div> */}
            </div>
          </div>
        </Modal>
      </div>
    </div>
  );
};

export default Index;
