import Card from "components/card";
import { useEffect, useState } from "react";
import cateApi from "../../../api/categoryAPI";
import { Link } from "react-router-dom";
import { useForm } from "react-hook-form";
import bookApi from "../../../api/bookApi";
import Alert from "components/alert";
import { useNavigate } from "react-router-dom";
import Chip from "@mui/material/Chip";
import Stack from "@mui/material/Stack";
import { toast, ToastContainer } from "react-toastify";
import { MultiSelect } from "react-multi-select-component";
export function Create() {
  const [catesList, setCates] = useState([]);
  const [authors, setAuthors] = useState([]);
  const [selectedAuthor, setSelectedAuthor] = useState([]);
  const [bookName, setBookName] = useState("");
  const [cateId, setCateId] = useState();
  const [trigger, setTrigger] = useState();
  const navigate = useNavigate();
  useEffect(() => {
    const getall = async () => {
      const data = await cateApi.GetAll();
      setCates(data);
    };
    getall();
    const getAllAuthor = async () => {
      const data = await bookApi.GetAllAuthor();
      setAuthors(data);
    };
    getAllAuthor();
  }, []);

  const { register, handleSubmit } = useForm();

  const [imageUploadFile, setImageUploadFile] = useState(null);
  const onFileChange = (event) => {
    setImageUploadFile(event.target.files[0]);
  };

  const addBook = async () => {
    var dto = {};
    dto.name = bookName;
    dto.categoryId = cateId;
    dto.listAuthors = selectedAuthor;
    await bookApi.CreateNewBook(dto).then((res) => {
      if (res.statusCode === 200) {
        Alert.showSuccessAlert("Add your book sucessfully!");
        navigate("/admin/books");
      }
    });
  };

  const [disabled, setDisabled] = useState(false);
  const [authorName, setAuthorName] = useState("");
  const addNewAuthor = async () => {
    await bookApi.CreateNewAuthor(authorName).then((res) => {
      if (res.statusCode === 200) {
        toast.success(res.message);
        setTrigger(Math.random() + 1)
          ?.toString(36)
          .substring(7);
      }
    });

    setDisabled(false);
  };
  return (
    <div className="mt-5 gap-5 xl:grid-cols-2">
      <Card extra={"w-full h-fit px-6 pb-6 sm:overflow-x-auto"}>
        <div className="relative flex items-center justify-between pt-4">
          <div className="text-xl font-bold text-navy-700 dark:text-white">
            Add new book
          </div>
        </div>
        <div className="mt-2 flex h-fit w-full justify-center overflow-x-scroll xl:overflow-hidden">
          <div className="mb-2 w-80 max-w-screen-lg sm:w-96">
            <div className="mb-4 flex flex-col gap-6">
              <div>
                <label for="name" class="text-m text-navy-700 dark:text-white">
                  Name
                </label>
                <input
                  className={`mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none`}
                  value={bookName}
                  onChange={(event) => setBookName(event.target.value)}
                  label="Book name"
                  placeholder=""
                  id="name"
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
                  value={cateId}
                  onChange={(event) => setCateId(event.target.value)}
                  class="mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none"
                >
                  <option selected>Choose a category</option>
                  {catesList.map((row, key) => {
                    return <option value={row.id}>{row.name}</option>;
                  })}
                </select>
              </div>
              {disabled === false && (
                <div>
                  <label
                    for="categories"
                    class="text-m mb-5 text-navy-700 dark:text-white"
                  >
                    Author
                  </label>
                  <div className="flex w-full items-center">
                    <MultiSelect
                      options={authors}
                      value={selectedAuthor}
                      onChange={setSelectedAuthor}
                      labelledBy="Select"
                      className="!w-[384px]"
                    />
                    <button
                      onClick={() => setDisabled(true)}
                      className="linear ml-2 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
                    >
                      Add
                    </button>
                  </div>
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
              )}
              {disabled === true && (
                <div>
                  <label
                    for="name"
                    class="text-m text-navy-700 dark:text-white"
                  >
                    Add new author
                  </label>
                  <input
                    className={`mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none`}
                    autoFocus
                    value={authorName}
                    onChange={(event) => setAuthorName(event.target.value)}
                    label="Book name"
                    type="text"
                  />
                  <div className="mt-3 flex">
                    <button
                      onClick={() => addNewAuthor()}
                      className="linear ml-2 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
                    >
                      Add
                    </button>
                    <button
                      onClick={() => setDisabled(false)}
                      className="linear ml-2 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
                    >
                      Cancel
                    </button>
                  </div>
                </div>
              )}
              <div>
                <label for="name" class="text-m text-navy-700 dark:text-white">
                  Add new author
                </label>
                <input
                  className={`mt-2 flex h-12 w-full items-center justify-center rounded-xl border bg-white/0 p-3 text-sm outline-none`}
                  autoFocus
                  value={authorName}
                  onChange={(event) => setAuthorName(event.target.value)}
                  label="Book name"
                  type="text"
                />
                <div className="mt-3 flex">
                  <button
                    onClick={() => addNewAuthor()}
                    className="linear ml-2 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
                  >
                    Add
                  </button>
                  <button
                    onClick={() => setDisabled(false)}
                    className="linear ml-2 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
                  >
                    Cancel
                  </button>
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
                onClick={() => addBook()}
                className="linear ml-2 mt-4 flex items-center justify-center rounded-xl bg-brand-500 px-2 py-2 text-base font-medium text-white transition duration-200 hover:bg-brand-600 active:bg-brand-700 dark:bg-brand-400 dark:text-white dark:hover:bg-brand-300 dark:active:bg-brand-200"
              >
                Add book
              </button>
            </div>
          </div>
        </div>
      </Card>
    </div>
  );
}

export default Create;
