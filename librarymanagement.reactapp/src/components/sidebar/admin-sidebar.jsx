/* eslint-disable */

import { HiX } from "react-icons/hi";
import Links from "./components/Links";
import routes from "./admin-sidebar-routes";
import Logo from "assets/img/logo/Bookstore.png";
import SidebarCard from "components/sidebar/components/SidebarCard";

const AdminSidebar = ({ open, onClose }) => {
  return (
    <div
      className={`sm:none duration-175 linear fixed !z-50 m-4 mb-10 flex min-h-full w-[290px] flex-col rounded-xl bg-white shadow-2xl shadow-white/5 transition-all dark:!bg-navy-800 dark:text-white md:!z-50 lg:!z-50 xl:!z-0 ${
        open ? "translate-x-0" : "-translate-x-96"
      }`}
    >
      <span
        className="absolute right-4 top-4 block cursor-pointer xl:hidden"
        onClick={onClose}
      >
        <HiX />
      </span>

      <div
        className={`mx-[56px] mb-[20px] ml-8 mt-[20px] flex items-center justify-center`}
      >
        <img className="h-[80px] w-auto" src={Logo} alt="" />
      </div>
      <div class="mb-[10px] h-px bg-gray-300 dark:bg-white/30" />
      {/* Nav item */}

      <ul className="mb-auto pt-1 ">
        <Links routes={routes} />
      </ul>

      {/* Free Horizon Card */}
      <div className="flex justify-center">
        {/* <SidebarCard /> */}

        <SidebarCard />
      </div>
      {/* Nav item end */}
    </div>
  );
};

export default AdminSidebar;
