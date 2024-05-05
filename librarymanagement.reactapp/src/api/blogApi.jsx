import API from "./API";
import APIFile from "./API.File";
const postApi = {
  GetAll: () => {
    return API.get("/Blogs");
  },
  GetBlogPagination: (dto) => {
    return API.post("/Blogs/GetBlogPagination", dto);
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
  UpdateStatusBlog: (dto) => {
    return API.put("/Blogs/UpdateStatusBlog", dto);
  },
  GetBlogByUserAccount: (AccountId) => {
    return API.get(`/Blogs/${AccountId}`);
  },
  GetAllTopic: () => {
    return API.get("/Topics");
  },
  GetBlogByTopic: (topicId) => {
    return API.get(`/Blogs/GetBlogByTopic/${topicId}`);
  },
};

export default postApi;
