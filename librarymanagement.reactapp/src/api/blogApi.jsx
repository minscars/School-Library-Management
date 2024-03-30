import API from "./API";
import APIFile from "./API.File";
const postApi = {
  GetAll: () => {
    return API.get("/Blogs");
  },
  GetById: (id) => {
    return API.get(`/Blogs/Detail/${id}`);
  },
  PostNewPost: (request) => {
    return APIFile.post("/Posts", request);
  },
  GetByStatusPost: (idStatus) => {
    return API.get(`/Blogs/Status/${idStatus}`);
  },
};

export default postApi;
