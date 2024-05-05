import API from "./API";
const bookApi = {
  GetAll: (dto) => {
    return API.post("/Books/GetBookPagination", dto);
  },
  GetDetailBook: (bookId) => {
    return API.get(`/Books/GetDetail/${bookId}`);
  },
  UpdateBook: (dto) => {
    return API.put("/Books", dto);
  },
  GetAllAuthor: () => {
    return API.get("/Books/GetAllAuthor");
  },
  CreateNewAuthor: (authorName) => {
    return API.post("/Books/CreateNewAuthor", authorName);
  },
  CreateNewBook: (dto) => {
    return API.post("/Books/CreateNewBook", dto);
  },
};

export default bookApi;
