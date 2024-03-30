import React, { useRef, useEffect, useState } from "react";
// Import Swiper React components
import { Swiper, SwiperSlide } from "swiper/react";
import publishedBookApi from "api/publishedBookApi";
// Import Swiper styles
import "swiper/css";
import "swiper/css/free-mode";
import "swiper/css/pagination";
import BookCard from "components/card/BookCard";
import "./styles.css";

// import required modules
import { FreeMode, Pagination, Autoplay } from "swiper/modules";

export default function App() {
  const [topFiveList, setTopFive] = useState([]);
  useEffect(() => {
    const getTopFive = async () => {
      const data = await publishedBookApi.GetTopFive();
      setTopFive(data);
    };
    getTopFive();
  }, []);
  return (
    <>
      <Swiper
        slidesPerView={4}
        spaceBetween={20}
        freeMode={true}
        autoplay={{
          delay: 1500,
          disableOnInteraction: false,
        }}
        pagination={{
          clickable: true,
        }}
        modules={[FreeMode, Autoplay, Pagination]}
        className="mySwiper"
      >
        {topFiveList?.map((item) => (
          <SwiperSlide>
            <BookCard data={item} />
          </SwiperSlide>
        ))}
      </Swiper>
    </>
  );
}
