import API from "./API";
import APIFile from "./API.File";
const publishedBookApi = {
  GetAll: (request) => {
    return API.post(`/PublishedBooks/GetAll`, request);
  },
  GetById: (id) => {
    return API.get(`/PublishedBooks/${id}`);
  },
  GetByCateId: (cateId) => {
    return API.get(`/PublishedBooks/Category/${cateId}`);
  },
  Search: (Key) => {
    return API.get(`/PublishedBooks/Search/${Key}`);
  },
  GetTopFive: () => {
    return API.get("/PublishedBooks/TopFive");
  },
  GetBookRelatedList: (publishedBookId) => {
    return API.get(`/PublishedBooks/book-detail-related-list/${publishedBookId}`);
  },
  // Create: (request) => {
  //   return APIFile.post("/Books", request);
  // },
  // Delete: (id) => {
  //   return API.delete(`/Books/${id}`);
  // },
  // Edit: (request) => {
  //   return APIFile.put("/Books", request);
  // },
  // GetNewBook: () => {
  //   return API.get("/Books/NewBooks");
  // },
};

export default publishedBookApi;
