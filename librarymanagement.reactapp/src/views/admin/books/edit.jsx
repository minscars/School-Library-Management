import Card from "components/card";
import React, { useEffect, useState } from "react";
import cateApi from "api/categoryAPI";
import { Link } from "react-router-dom";
import { useForm } from "react-hook-form";
import bookApi from "api/bookApi";
import { MultiSelect } from "react-multi-select-component";
import Alert from "components/alert";
import { useNavigate, useParams } from "react-router-dom";
import Chip from "@mui/material/Chip";
import Stack from "@mui/material/Stack";

export function Update() {
  const [catesList, setCates] = useState([]);
  const [book, setBook] = useState([]);
  const [authors, setAuthors] = useState([]);
  const { id } = useParams();
  const navigate = useNavigate();
  const [bookName, setBookName] = useState(book?.name);
  const [categoryIdValue, setCategoryId] = useState(book?.categoryId);
  const [selectedAuthor, setSelectedAuthor] = useState(
    book?.authors ? book?.authors : []
  );
  useEffect(() => {
    const getall = async () => {
      const data = await cateApi.GetAll();
      setCates(data);
    };
    getall();

    const getbyid = async () => {
      const data = await bookApi.GetDetailBook(id);
      setBook(data);
    };
    getbyid();

    const getAllAuthor = async () => {
      const data = await bookApi.GetAllAuthor();
      setAuthors(data);
    };
    getAllAuthor();
  }, [id]);

  useEffect(() => {
    if (book?.authors && book?.authors.length) {
      setSelectedAuthor(book?.authors);
    }
    setCategoryId(book?.categoryId);
    setBookName(book?.name);
  }, [book]);

  const { register, handleSubmit } = useForm();

  const editBook = async () => {
    var name = bookName;
    var categoryId = categoryIdValue;
    var dto = { id, name, categoryId };
    dto.authors = selectedAuthor;
    console.log(dto);
    // await bookApi.Edit(dto).then((response) => {
    //   if (response.statusCode === 200) {
    //     Alert.showSuccessAlert(response.message, navigate("/admin/books"));
    //   } else {
    //     Alert.showErrorAlert(response.message);
    //   }
    // });
  };

  return (
    <div className="mt-5 gap-5 xl:grid-cols-2">
      <Card extra={"w-full h-[600px] px-6 pb-6 sm:overflow-x-auto"}>
        <div className="relative flex items-center justify-between pt-4">
          <div className="text-xl font-bold text-navy-700 dark:text-white">
            Update your{" "}
            <span>
              {'"'}
              {book.name}
              {'"'}
            </span>{" "}
            Book
          </div>
        </div>
        <div className="mt-8 flex h-full w-full justify-center overflow-x-scroll xl:overflow-hidden">
          <form
            onSubmit={handleSubmit(editBook)}
            enctype="multipart/form-data"
            className="mb-2 w-80 max-w-screen-lg sm:w-96"
            method="post"
          >
            <div className="mb-4 flex flex-col gap-6">
              <div>
                <label for="name" class="text-m text-navy-700 dark:text-white">
                  Name
                </label>
                <input
                  className={`mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none`}
                  autoFocus
                  value={bookName}
                  onChange={(event) => setBookName(event.target.value)}
                  label="Book name"
                  type="text"
                />
              </div>

              <div>
                <label
                  for="categories"
                  class="text-m mb-5 text-navy-700 dark:text-white"
                >
                  Category
                </label>
                <select
                  required
                  value={categoryIdValue}
                  onChange={(event) => setCategoryId(event.target.value)}
                  class="mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                >
                  {catesList?.map((row) => (
                    <option key={row.id} value={row.id}>
                      {row.name}
                    </option>
                  ))}
                </select>
              </div>

              <div>
                <label
                  for="categories"
                  class="text-m mb-5 text-navy-700 dark:text-white"
                >
                  Author
                </label>

                <MultiSelect
                  options={authors}
                  value={selectedAuthor}
                  onChange={setSelectedAuthor}
                  labelledBy="Select"
                />
                <div className="mt-2">
                  <Stack direction="row" spacing={1}>
                    {selectedAuthor?.map((item) => (
                      <Chip
                        key={item.value}
                        label={item.label}
                        //onClick={handleClick}
                        //onDelete={handleDelete}
                      />
                    ))}
                  </Stack>
                </div>
              </div>
            </div>

            <div className=" linear float-right mt-4 flex items-center ">
              <Link to="/admin/books">
                <button className="linear mt-4 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200">
                  Cancel
                </button>
              </Link>

              <button
                type="submit"
                className="linear ml-2 mt-4 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
              >
                Update
              </button>
            </div>
          </form>
        </div>
      </Card>
    </div>
  );
}

export default Update;
