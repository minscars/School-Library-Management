import { Link } from "react-router-dom";
import BookCard from "components/card/BookCard";
import { useEffect, useState } from "react";
import publishedBookApi from "../../../api/publishedBookApi";
import Card from "components/card";
import Pagination from "components/pagination";
import { FiSearch } from "react-icons/fi";
const Marketplace = () => {
  const [booksList, setBooks] = useState([]);
  const [topFiveList, setTopFive] = useState([]);
  const [page, setPage] = useState(0);
  const [limit] = useState(4);
  const [currentPage, setCurrentPage] = useState(0);
  const [pageCount, setPageCount] = useState(0);
  const [isloaded, setIsLoaded] = useState(false);

  useEffect(() => {
    const getTopFive = async () => {
      const data = await publishedBookApi.GetTopFive();
      setTopFive(data);
    };
    getTopFive();
    getAllBooksFromReact();
  }, [limit, page]);

  const getAllBooksFromReact = async () => {
    const dto = { page, limit };
    setIsLoaded(false);
    const response = await publishedBookApi.GetAll(dto);
    setPageCount(Math.ceil(response.totalRecord / limit));
    setBooks(response.data);
    setIsLoaded(true);
  };

  const [typeSearch, setTypeSearch] = useState(1);
  const handleChaneTypeSearch = (e) => {
    setTypeSearch(e.target.value);
  };

  const [searchText, setSearchText] = useState("");
  async function handleSearch(e) {
    e.preventDefault();
    var type = typeSearch;
    var search = searchText;
    const dto = { page, limit, type, search };
    setIsLoaded(false);
    const response = await publishedBookApi.GetAll(dto);
    setPageCount(Math.ceil(response.totalRecord / limit));
    setBooks(response.data);
    setIsLoaded(true);
    setSearchText("");
  }

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setPage(e.selected);
  };

  return (
    <div className="grid h-full grid-cols-1 gap-5 xl:grid-cols-2 2xl:grid-cols-3">
      <div className="col-span-1 h-fit w-full xl:col-span-1 2xl:col-span-2">
        <div className="h-82 mb-2 !h-auto overflow-hidden rounded-[10px] rounded-xl bg-cover bg-center !p-0">
          <form
            onSubmit={(e) => handleSearch(e)}
            className="left-0 right-0 !mb-0 flex justify-center rounded-[5px] bg-white bg-cover px-2 py-2 text-[16px] text-gray-800"
          >
            <select
              onChange={(e) => handleChaneTypeSearch(e)}
              className="flex h-12 h-full  rounded-[10px] bg-lightPrimary p-3 text-[16px] outline-none"
              name=""
              id=""
            >
              <option value={1}>Title</option>
              <option value={2}>Author</option>
              <option value={3}>Publisher</option>
              <option value={4}>Published year</option>
            </select>
            <input
              onChange={(e) => setSearchText(e.target.value)}
              type="text"
              placeholder="Type here..."
              className="ml-4 block h-full !w-[500px] rounded-[10px] bg-lightPrimary  px-4 py-3 text-[16px] text-sm font-medium text-navy-700 outline-none placeholder:!text-gray-400 dark:bg-navy-900 dark:text-white dark:placeholder:!text-white sm:w-fit"
            />
            {/* <div className="linear ml-4 flex cursor-pointer items-center rounded-[10px] bg-cyan-700 px-4 py-1 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"> */}
            <button
              type="submit"
              className="linear ml-4 flex cursor-pointer items-center rounded-[10px] bg-cyan-700 px-4 py-1 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
            >
              <FiSearch className="h-4 w-4 text-gray-400 dark:text-white" />
            </button>
          </form>
        </div>
        {/* NFTs trending card */}
        <div className=" h-[540px] ">
          {booksList?.map((data) => (
            <Link to={`/user/books/detail/${data.id}`}>
              <Card
                extra={`w-full !h-[130px] !p-4 3xl:p-![18px] bg-white mb-2`}
              >
                <div className="flex">
                  <div>
                    <img
                      src={data.image}
                      className="mb-3 h-[100px] w-auto rounded-l border-2 3xl:h-full 3xl:w-full"
                      alt={data.title}
                    />
                  </div>
                  <div>
                    <div className="flex items-center">
                      <div className="mb-1 ml-1 flex items-center justify-center px-1">
                        <div className="mb-2">
                          <p className="text-sm font-bold text-navy-700 dark:text-white">
                            {" "}
                            {data.title}{" "}
                          </p>
                          <div className="flex">
                            <p className="text-sm font-medium text-gray-600">
                              By
                            </p>
                            {data.authors?.map((item) => (
                              <p
                                key={item.id}
                                className="ml-1 w-auto text-sm font-medium text-gray-600"
                              >
                                {item.name},
                              </p>
                            ))}
                          </div>
                        </div>
                      </div>
                    </div>
                    <p className="ml-2 ">
                      {" "}
                      <span className="text-sm font-bold text-navy-700 dark:text-white">
                        Location:{" "}
                      </span>
                      {data.bookLocation?.map((item) => (
                        <span className="text-sm text-cyan-500" key={item.id}>
                          {item.name}
                        </span>
                      ))}
                    </p>
                    <p className="w-auto text-sm font-medium text-gray-600">
                      {" "}
                      <span className="ml-2 mt-1 text-sm font-bold text-navy-700 dark:text-white">
                        Published info:{" "}
                      </span>
                      {data.publisherName}, {data.publishedYear}
                    </p>
                  </div>
                </div>
              </Card>
            </Link>
          ))}
        </div>
        <Pagination
          handlePageClick={handlePageClick}
          currentPage={currentPage}
          pageCount={pageCount}
        />
      </div>

      {/* right side section */}

      <div className="col-span-1 h-full w-full rounded-xl 2xl:col-span-1">
        <Card extra={"w-full p-4"}>
          <h4 className="text-lg font-bold text-navy-700 dark:text-white">
            Top books
          </h4>
          {topFiveList?.map((item) => (
            <div
              key={item.id}
              className="mt-3 flex w-full items-center justify-between rounded-2xl bg-white p-3 shadow-3xl shadow-shadow-500 dark:!bg-navy-700 dark:shadow-none"
            >
              <Link to={`/user/books/detail/`}>
                <div className="flex items-center">
                  <div className="">
                    <img
                      className="h-[83px] w-full rounded-lg border-2"
                      src={item.image}
                      alt=""
                    />
                  </div>
                  <div className="ml-4">
                    <p className="text-base font-medium text-navy-700 dark:text-white">
                      {item.title}
                    </p>
                    <p className="mt-2 text-sm text-gray-600">
                      Borrowed:{" "}
                      <span className="ml-1 font-medium text-brand-500 hover:text-brand-500 dark:text-white">
                        {item.checkout_visit}
                      </span>
                    </p>
                  </div>
                </div>
              </Link>
            </div>
          ))}
        </Card>
      </div>
    </div>
  );
};

export default Marketplace;
