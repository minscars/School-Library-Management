import React from "react";
import Dropdown from "components/dropdown";
import { AiOutlineUser } from "react-icons/ai";
import { BsThreeDots } from "react-icons/bs";
import { FiSettings } from "react-icons/fi";
import { AiOutlineShop } from "react-icons/ai";
import { TiLightbulb } from "react-icons/ti";
import feedBackApi from "api/feedBackApi";
import Swal from "sweetalert2";
import Alert from "components/alert";
function CardMenu(props) {
  const { transparent } = props;
  const [open, setOpen] = React.useState(false);
  async function deleteFeedBack(feedBackId) {
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to delete this feedback?",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, I want it!",
    }).then(async (result) => {
      if (result.isConfirmed) {
        await feedBackApi.DeleteFeedBack(feedBackId).then(async (res) => {
          if (res.statusCode === 200) {
            Alert.showSuccessAlert(res.message);
          } else {
            Alert.showErrorAlert(res.message);
          }
        });
      }
    });
  }
  return (
    <Dropdown
      button={
        <button onClick={() => setOpen(!open)} open={open}>
          <BsThreeDots color="gray" className=" h-5 w-5" />
        </button>
      }
      animation={"origin-top-right transition-all duration-300 ease-in-out"}
      classNames={`${transparent ? "top-8" : "top-6"} right-0 w-max`}
      children={
        <div
          onClick={() => deleteFeedBack(props.feedBackId)}
          className="z-100 w-max rounded-[5px] bg-white p-2 text-sm shadow-xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none"
        >
          <p className="hover:text-black flex cursor-pointer items-center gap-2 text-red-500 hover:font-medium">
            <span>
              <FiSettings />
            </span>
            <p className="">Delete</p>
          </p>
        </div>
      }
    />
  );
}

export default CardMenu;
