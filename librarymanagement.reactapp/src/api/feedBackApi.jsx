import API from "./API";

const feedBackApi = {
  GetFeedBack: (publishedBookId) => {
    return API.get(`/FeedBacks/${publishedBookId}`);
  },
  AddFeedBack: (dto) => {
    return API.post("/FeedBacks", dto)
  }
};

export default feedBackApi;
