/* eslint-disable */
import React from "react";
import { Link, useLocation } from "react-router-dom";
import DashIcon from "components/icons/DashIcon";
// chakra imports

export function SidebarLinks(props) {
  // Chakra color mode
  let location = useLocation();

  const { routes } = props;

  // verifies if routeName is the one active (in browser input)
  const activeRoute = (routeName) => {
    return location.pathname.includes(routeName);
  };

  const createLinks = (routes) => {
    return routes.map((route, index) => {
      if (
        route.layout === "/admin" ||
        route.layout === "/auth" ||
        route.layout === "/user"
      ) {
        return (
          <Link key={index} to={route.layout + "/" + route.path}>
            <div className="relative  mb-6 mr-2 flex rounded-lg hover:cursor-pointer hover:bg-gray-100">
              <li
                className="my-[10px] flex  cursor-pointer items-center px-8  "
                key={index}
              >
                <span
                  className={`${
                    activeRoute(route.path) === true
                      ? "font-bold text-customcolor-500 dark:text-white"
                      : "font-medium text-gray-600"
                  }`}
                >
                  {route.icon ? route.icon : <DashIcon />}{" "}
                </span>
                <p
                  className={`leading-1 ml-4  flex text-[18px] ${
                    activeRoute(route.path) === true
                      ? "font-bold text-customcolor-500 dark:text-white"
                      : "font-medium text-gray-600"
                  }`}
                >
                  {route.name}
                </p>
              </li>
              {activeRoute(route.path) ? (
                <div class="absolute right-0 top-px h-[43px] w-1 items-center rounded-lg bg-customcolor-500 dark:bg-brand-400" />
              ) : null}
            </div>
          </Link>
        );
      }
    });
  };
  // BRAND
  return createLinks(routes);
}

export default SidebarLinks;
