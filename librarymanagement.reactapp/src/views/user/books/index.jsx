import BookCard from "components/card/BookCard";
import "react-toastify/dist/ReactToastify.css";
import { useEffect, useState } from "react";
import bookApi from "../../../api/publishedBookApi";
import cateApi from "../../../api/categoryAPI";
import { Link, useSearchParams } from "react-router-dom";
import Card from "components/card";
import Pagination from "components/pagination";
const Marketplace = () => {
  const [booksList, setBooks] = useState([]);
  const [catesList, setCate] = useState([]);
  const [searchParams] = useSearchParams();
  const [offset, setOffset] = useState(0);
  const [perPage] = useState(10);
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
    <div className="gap-5 xl:grid-cols-2">
      <Card extra={"w-full  px-4 pb-6 mb-4 "}>
        <div class="relative sticky mb-2 flex items-center justify-between pt-2">
          <div class="text-xl font-bold text-navy-700 dark:text-white">
            All Books
          </div>
          <div className="mr-4">
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
        </div>
        <div className="col-span-1 h-[550px] w-full xl:col-span-1 2xl:col-span-2">
          <div className="z-20 grid grid-cols-1 gap-5 md:grid-cols-5">
            {booksList?.map((row) => (
              <Link to={`/user/books/detail/${row.id}`}>
                <BookCard data={row} />
              </Link>
            ))}
          </div>
        </div>
        <Pagination
          handlePageClick={handlePageClick}
          currentPage={currentPage}
          pageCount={pageCount}
        />
      </Card>
    </div>
  );
};

export default Marketplace;
