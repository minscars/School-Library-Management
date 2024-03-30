import { Link } from "react-router-dom";
import BookCard from "components/card/BookCard";
import { useEffect, useState } from "react";
import publishedBookApi from "../../../api/publishedBookApi";
import Card from "components/card";
import Carousel from "components/carousel/index";
import Pagination from "components/pagination";
const Marketplace = () => {
  const [booksList, setBooks] = useState([]);
  const [topFiveList, setTopFive] = useState([]);
  const [page, setPage] = useState(0);
  const [limit] = useState(3);
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

  const handlePageClick = (e) => {
    setCurrentPage(e.selected);
    setPage(e.selected);
  };

  return (
    <div className="grid h-full grid-cols-1 gap-5 xl:grid-cols-2 2xl:grid-cols-3">
      <div className="col-span-1 h-fit w-full xl:col-span-1 2xl:col-span-2">
        <div className="h-82 overflow-hidden rounded-xl bg-cover	bg-center">
          <Carousel />
        </div>
        {/* NFTs trending card */}
        <div className="z-20 mt-4 grid h-[270px] grid-cols-1 gap-5 md:grid-cols-3">
          {booksList?.map((row) => (
            <Link to={`/user/books/detail/${row.id}`}>
              <BookCard data={row} />
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
