import Api from "./API";

const bookRequestApi = {
  GetAll: (request) => {
    return Api.post("/BookRequest/GetAll", request);
  },
  GetByAccount: (dto) => {
    return Api.post(`/BookRequest/GetByUserAccount`, dto);
  },
  GetDetail: (BookRequestId) => {
    return Api.get(`/BookRequest/${BookRequestId}`);
  },
  CreateNewBookRequest: (dto) => {
    return Api.post("/BookRequest", dto);
  },
  GetByStatus: (bookRequestStatus) => {
    return Api.get(`/BookRequest/Status/${bookRequestStatus}`);
  },
  UpdateStatus: (dto) => {
    return Api.put("/BookRequest/UpdateStatus", dto);
  },
};

export default bookRequestApi;
