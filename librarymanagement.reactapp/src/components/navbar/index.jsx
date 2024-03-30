import React, { useEffect, useState } from "react";
import Dropdown from "components/dropdown";
import { FiAlignJustify } from "react-icons/fi";
import { Link, useNavigate } from "react-router-dom";
import navbarimage from "assets/img/layout/Navbar.png";
import { BsArrowBarUp } from "react-icons/bs";
import { FiSearch } from "react-icons/fi";
import { RiMoonFill, RiSunFill } from "react-icons/ri";
import moment from "moment";
import {
  IoMdNotificationsOutline,
  IoMdInformationCircleOutline,
} from "react-icons/io";
import userAccountAPI from "api/accountApi";
import jwt from "jwt-decode";
import Alert from "components/alert";
import Swal from "sweetalert2";
const Navbar = (props) => {
  const navigate = useNavigate();
  const { onOpenSidenav, brandText } = props;
  const [darkmode, setDarkmode] = React.useState(false);
  const [searchText, setSearchText] = React.useState("");
  const [user, setUser] = useState(null);
  const userLogin = jwt(window.localStorage.getItem("token"));

  useEffect(() => {
    const getUser = async () => {
      const user = await userAccountAPI.GetUserAccount(userLogin.id);
      setUser(user);
    };
    getUser();
  }, []);
  async function handleSearch(e) {
    e.preventDefault();
    if (searchText != "") {
      window.location.pathname.includes("admin")
        ? navigate("/admin/books/?search=" + searchText)
        : navigate("/user/books/?search=" + searchText);
    }
    setSearchText("");
  }

  const handleLogout = async () => {
    Swal.fire({
      title: "Are you sure?",
      text: "Do you want to log-out?",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, I want it!",
    }).then(async (result) => {
      if (result.isConfirmed) {
        window.localStorage.removeItem("token");
        Alert.showSuccessAlert("You have been log-outed sucessfully!");
        navigate(`/auth/sign-in`);
      }
    });
  };

  return (
    <nav className="sticky top-0 z-40 flex flex-row flex-wrap items-center justify-between rounded-xl bg-white/10 p-2 backdrop-blur-xl dark:bg-[#0b14374d]">
      {userLogin.roles == "User" && (
        <div className="ml-[6px]">
          <div className="h-6 w-[224px] pt-1">
            <a
              className="text-sm font-normal text-navy-700 hover:underline dark:text-white dark:hover:text-white"
              href=" "
            >
              Pages
              <span className="mx-1 text-sm text-navy-700 hover:text-navy-700 dark:text-white">
                {" "}
                /{" "}
              </span>
            </a>
            <Link className="text-sm font-normal capitalize text-navy-700 hover:underline dark:text-white dark:hover:text-white">
              {brandText}
            </Link>
          </div>
          <p className="shrink text-[25px] capitalize text-navy-700 dark:text-white">
            <Link className="font-bold capitalize text-customcolor-500 hover:text-navy-700 dark:hover:text-white">
              {brandText}
            </Link>
          </p>
        </div>
      )}

      {/* Form search */}
      {userLogin.roles == "User" && (
        <div className="relative  flex h-[61px] w-[355px] flex-grow items-center justify-around gap-2 rounded-full bg-white px-2 py-2 shadow-xl shadow-shadow-500 dark:!bg-navy-800 dark:shadow-none md:w-[365px] md:flex-grow-0 md:gap-1 xl:w-[365px] xl:gap-2">
          <div className="flex h-full items-center rounded-full bg-lightPrimary text-navy-700 dark:bg-navy-900 dark:text-white xl:w-[225px]">
            <p className="pl-3 pr-2 text-xl">
              <FiSearch className="h-4 w-4 text-gray-400 dark:text-white" />
            </p>
            <form onSubmit={(e) => handleSearch(e)}>
              <input
                onChange={(e) => setSearchText(e.target.value)}
                type="text"
                placeholder="Search..."
                className="mt-4 block h-full w-full rounded-full bg-lightPrimary text-sm font-medium text-navy-700 outline-none placeholder:!text-gray-400 dark:bg-navy-900 dark:text-white dark:placeholder:!text-white sm:w-fit"
                value={searchText}
              />
            </form>
          </div>
          <span
            className="flex cursor-pointer text-xl text-gray-600 dark:text-white xl:hidden"
            onClick={onOpenSidenav}
          >
            <FiAlignJustify className="h-5 w-5" />
          </span>
          {/* start Notification */}
          <Dropdown
            button={
              //onclick to recall API notification
              <p className="cursor-pointer">
                <IoMdNotificationsOutline className="h-4 w-4 text-gray-600 dark:text-white" />
              </p>
            }
            animation="origin-[65%_0%] md:origin-top-right transition-all duration-300 ease-in-out"
            children={
              <div className="flex w-[360px] flex-col gap-3 rounded-[20px] bg-white p-4 shadow-xl shadow-shadow-500 dark:!bg-navy-700 dark:text-white dark:shadow-none sm:w-[460px]">
                <div className="flex items-center justify-between">
                  <p className="text-base font-bold text-navy-700 dark:text-white">
                    Notification
                  </p>
                  <p className="text-sm font-bold text-navy-700 dark:text-white">
                    Mark all read
                  </p>
                </div>

                <button className="flex w-full items-center">
                  {/* <div className="flex h-full w-[85px] items-center justify-center rounded-xl bg-gradient-to-b from-brandLinear to-brand-500 py-4 text-2xl text-white"> */}
                  {/*<BsArrowBarUp />*/}
                  {/*</div>*/}
                  <div className="ml-2 flex h-full w-full flex-col justify-center rounded-lg px-1 text-sm">
                    <p className="mb-1 text-left text-base font-bold text-gray-900 dark:text-white"></p>
                    <div className="flex justify-between">
                      <p className="font-base text-left text-xs text-gray-900 dark:text-white"></p>
                      <p className="font-base text-left text-xs text-gray-900 dark:text-white">
                        Status: <span></span>
                      </p>
                    </div>
                  </div>
                </button>
              </div>
            }
            classNames={"py-2 top-4 -left-[230px] md:-left-[440px] w-max"}
          />
          {/* start Horizon PRO */}
          <Dropdown
            button={
              <p className="cursor-pointer">
                <IoMdInformationCircleOutline className="h-4 w-4 text-gray-600 dark:text-white" />
              </p>
            }
            children={
              <div className="flex w-[350px] flex-col gap-2 rounded-[20px] bg-white p-4 shadow-xl shadow-shadow-500 dark:!bg-navy-700 dark:text-white dark:shadow-none">
                <div
                  style={{
                    backgroundImage: `url(${navbarimage})`,
                    backgroundRepeat: "no-repeat",
                    backgroundSize: "cover",
                  }}
                  className="mb-2 aspect-video w-full rounded-lg"
                />
                <a
                  target="blank"
                  href="https://horizon-ui.com/pro?ref=live-free-tailwind-react"
                  className="px-full linear flex cursor-pointer items-center justify-center rounded-xl bg-brand-500 py-[11px] font-bold text-white transition duration-200 hover:bg-brand-600 hover:text-white active:bg-brand-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:bg-brand-200"
                >
                  Buy Horizon UI PRO
                </a>
                <a
                  target="blank"
                  href="https://horizon-ui.com/docs-tailwind/docs/react/installation?ref=live-free-tailwind-react"
                  className="px-full linear flex cursor-pointer items-center justify-center rounded-xl border py-[11px] font-bold text-navy-700 transition duration-200 hover:bg-gray-200 hover:text-navy-700 dark:!border-white/10 dark:text-white dark:hover:bg-white/20 dark:hover:text-white dark:active:bg-white/10"
                >
                  See Documentation
                </a>
                <a
                  target="blank"
                  href="https://horizon-ui.com/?ref=live-free-tailwind-react"
                  className="hover:bg-black px-full linear flex cursor-pointer items-center justify-center rounded-xl py-[11px] font-bold text-navy-700 transition duration-200 hover:text-navy-700 dark:text-white dark:hover:text-white"
                >
                  Try Horizon Free
                </a>
              </div>
            }
            classNames={"py-2 top-6 -left-[250px] md:-left-[330px] w-max"}
            animation="origin-[75%_0%] md:origin-top-right transition-all duration-300 ease-in-out"
          />
          <div
            className="cursor-pointer text-gray-600"
            onClick={() => {
              if (darkmode) {
                document.body.classList.remove("dark");
                setDarkmode(false);
              } else {
                document.body.classList.add("dark");
                setDarkmode(true);
              }
            }}
          >
            {darkmode ? (
              <RiSunFill className="h-4 w-4 text-gray-600 dark:text-white" />
            ) : (
              <RiMoonFill className="h-4 w-4 text-gray-600 dark:text-white" />
            )}
          </div>
          {/* Profile & Dropdown */}
          <Dropdown
            button={
              <img
                className="h-10 w-10 cursor-pointer rounded-full"
                src={user?.avatar}
                alt="Elon Musk"
              />
            }
            children={
              <div className="flex w-56 flex-col justify-start rounded-[20px] bg-white bg-cover bg-no-repeat shadow-xl shadow-shadow-500 dark:!bg-navy-700 dark:text-white dark:shadow-none">
                <div className="p-4">
                  <div className="flex items-center gap-2">
                    <p className="text-sm font-bold text-navy-700 dark:text-white">
                      👋 Hey, {user?.name}
                    </p>{" "}
                  </div>
                </div>
                <div className="h-px w-full bg-gray-200 dark:bg-white/20 " />

                <div className="flex flex-col p-4">
                  <a
                    href=" "
                    className="text-sm text-gray-800 dark:text-white hover:dark:text-white"
                  >
                    Profile Settings
                  </a>
                  <a
                    href=" "
                    className="mt-3 text-sm text-gray-800 dark:text-white hover:dark:text-white"
                  >
                    Newsletter Settings
                  </a>

                  <a
                    onClick={() => handleLogout()}
                    className="mt-3 cursor-pointer text-sm font-medium text-red-500 hover:text-red-500"
                  >
                    Log Out
                  </a>
                </div>
              </div>
            }
            classNames={"py-2 top-8 -left-[180px] w-max"}
          />
        </div>
      )}
    </nav>
  );
};

export default Navbar;
