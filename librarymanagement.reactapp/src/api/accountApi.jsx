import Api from "./API";

const accountApi = {
  login: (request) => {
    return Api.post("/UserAccounts/Login", request);
  },

  GetUserAccount: (id) => {
    return Api.get(`/UserAccounts/${id}`);
  },

  // RegisterAccount: (request) => {
  //   return Api.post("/Users/Register", request);
  // },
};

export default accountApi;
