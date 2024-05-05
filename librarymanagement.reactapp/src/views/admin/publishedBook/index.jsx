import { useEffect, useState } from "react";
import { MdCancel, MdModeEditOutline } from "react-icons/md";
import Card from "components/card";
import { Link, useSearchParams } from "react-router-dom";
import Pagination from "components/pagination";
import bookApi from "../../../api/publishedBookApi";
import cateApi from "../../../api/categoryAPI";
const Index = () => {
  const [booksList, setBooks] = useState([]);
  const [catesList, setCate] = useState([]);
  const [searchParams] = useSearchParams();
  const [offset, setOffset] = useState(0);
  const [perPage] = useState(5);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);
  useEffect(() => {
    const GetAllCate = async () => {
      const data = await cateApi.GetAll();
      setCate(data);
    };
    GetAllCate();
    getAllBooksFromReact();
  }, [perPage, offset, searchParams.get("search")]);

  const getAllBooksFromReact = async () => {
    const formData = new FormData();
    formData.append("Page", offset);
    formData.append("Limit", perPage);
    if (searchParams.get("search")) {
      formData.append("Search", searchParams.get("search"));
    }
    setIsLoaded(false);
    console.log(formData);
    const response = await bookApi.GetAll(formData);
    setPageCount(Math.ceil(response.totalRecord / perPage));
    setBooks(response.data);
    setIsLoaded(true);
  };

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setOffset(e.selected);
  };

  async function handleFilter(e) {
    e.preventDefault();
    const formData = new FormData();
    formData.append("Page", offset);
    formData.append("Limit", perPage);
    formData.append("Key", e.target.value);
    if (e.target.value != 0) {
      const response = await bookApi.GetAll(formData);
      setPageCount(Math.ceil(response.totalRecord / perPage));
      setBooks(response.data);
    } else {
      const response = await bookApi.GetAll(formData);
      setPageCount(Math.ceil(response.totalRecord / perPage));
      setBooks(response.data);
    }
  }

  return (
    <div>
      <div className="gap-5 xl:grid-cols-2">
        <Card extra={"w-full px-6 pb-6"}>
          <div class="relative mb-2 pt-4">
            <div class="flex items-center justify-between text-xl font-bold text-navy-700 dark:text-white">
              <p className="left-0 top-0">Published books list</p>
              <div>
                <select
                  onChange={(e) => handleFilter(e)}
                  className="ml-4 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                >
                  <option
                    className="rounded-xl border bg-white/0 p-3 text-sm outline-none"
                    value={0}
                  >
                    All
                  </option>
                  {catesList?.map((item) => (
                    <option
                      className="rounded-xl border bg-white/0 p-3 text-sm outline-none"
                      key={item.id}
                      value={item.id}
                    >
                      {item.name}
                    </option>
                  ))}
                </select>
              </div>
              {/* <Link to="/admin/books/create">
                <button class="linear right-0 rounded-[20px] bg-cyan-700 px-4 py-2 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90">
                  + New book
                </button>
              </Link> */}
            </div>
          </div>
          <div className="mt-2 block h-[580px]">
            <table className="w-full">
              <thead className="sticky top-0 mb-1 bg-white">
                <tr>
                  <th className="border-b border-gray-200 pb-[10px] pr-[70px] text-start dark:!border-navy-700">
                    <p className="ml-10 items-center text-xs tracking-wide text-gray-600">
                      #
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[100px] text-start dark:!border-navy-700">
                    <p className="ml-10 text-xs tracking-wide text-gray-600">
                      NAME
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[60px] text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">
                      CATEGORY
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[40px] text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">
                      AVAILABLE
                    </p>
                  </th>
                  <th className="border-b border-gray-200 pb-[10px] pr-[40px] text-start dark:!border-navy-700">
                    <p className="text-xs tracking-wide text-gray-600">
                      ACTION
                    </p>
                  </th>
                </tr>
              </thead>
              <tbody>
                {booksList?.map((row, key) => (
                  <tr className="border-b-2 hover:bg-gray-100">
                    <td className="flex items-center justify-center pb-[9px] pt-[9px] sm:text-[15px]">
                      <p className="mr-8 text-sm font-bold text-navy-700 dark:text-white">
                        {key + 1}
                      </p>
                      <img
                        src={row.image}
                        alt=""
                        className="h-[90px] w-auto rounded-xl border-2 3xl:h-full 3xl:w-full"
                      />
                    </td>
                    <td className="ml-10 items-center pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="ml-10 mr-[18px] w-auto">
                        <Link to={`/admin/books/detail/${row.id}`}>
                          <p className="text-sm font-bold text-navy-700 dark:text-white">
                            {row.title}
                          </p>
                        </Link>
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-auto">
                        <p className=" text-justify text-sm font-bold text-navy-700 dark:text-white">
                          {row.category}
                        </p>
                      </div>
                    </td>
                    <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                      <div className="w-[40px]">
                        <p className="ml-5 text-justify text-sm font-bold text-navy-700 dark:text-white">
                          {row.available}
                        </p>
                      </div>
                    </td>
                    <td className="flex items-center gap-2 pb-[18px] pt-[14px] sm:text-[14px]">
                      <Link to={`./edit/${row.id}`}>
                        <MdModeEditOutline className="rounded-full text-xl" />
                      </Link>
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

export default Index;
