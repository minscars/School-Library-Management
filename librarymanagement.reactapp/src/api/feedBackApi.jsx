import API from "./API";

const feedBackApi = {
  GetFeedBack: (publishedBookId) => {
    return API.get(`/FeedBacks/${publishedBookId}`);
  },
  AddFeedBack: (dto) => {
    return API.post("/FeedBacks", dto);
  },
  DeleteFeedBack: (feedBackId) => {
    return API.delete(`/FeedBacks/${feedBackId}`);
  },
};

export default feedBackApi;
