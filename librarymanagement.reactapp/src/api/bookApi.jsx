import API from "./API";
const bookApi = {
  GetAll: () => {
    return API.get("/Books");
  },
};

export default bookApi;
