/* eslint-disable */

import { HiX } from "react-icons/hi";
import LinksUser from "./components/LinksUser";

import Logo from "assets/img/logo/LibraryManagementLogo.png";
import routes from "./user-sidebar-routes";
import SidebarCard from "components/sidebar/components/SidebarCard";

const UserSidebar = ({ open, onClose }) => {
  return (
    <div
      className={`sm:none duration-175 linear fixed !z-50 flex min-h-full flex-col bg-white pb-10 shadow-2xl shadow-white/5 transition-all dark:!bg-navy-800 dark:text-white md:!z-50 lg:!z-50 xl:!z-0 ${
        open ? "translate-x-0" : "-translate-x-96"
      }`}
    >
      <span
        className="absolute right-4 top-4 block cursor-pointer xl:hidden"
        onClick={onClose}
      >
        <HiX />
      </span>

      <div className={`mx-[56px] mb-[20px] ml-8 mt-[20px] flex items-center`}>
        <img className="h-[65px] w-full" src={Logo} alt="" />
      </div>
      <div class="mb-7 h-px bg-gray-300 dark:bg-white/30" />
      {/* Nav item */}

      <ul className="mt-[100px] items-center pt-1">
        <LinksUser routes={routes} />
      </ul>

      {/* Free Horizon Card */}
      <div className="flex justify-center">{/* <SidebarCard /> */}</div>

      {/* Nav item end */}
    </div>
  );
};

export default UserSidebar;
