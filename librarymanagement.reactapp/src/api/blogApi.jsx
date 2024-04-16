import API from "./API";
import APIFile from "./API.File";
const postApi = {
  GetAll: () => {
    return API.get("/Blogs");
  },
  GetById: (id) => {
    return API.get(`/Blogs/Detail/${id}`);
  },
  CreateBlog: (dto) => {
    return APIFile.post("/Blogs", dto);
  },
  GetByStatusPost: (idStatus) => {
    return API.get(`/Blogs/Status/${idStatus}`);
  },
};

export default postApi;
