import React, { useRef, useState } from "react";
// Import Swiper React components
import { Swiper, SwiperSlide } from "swiper/react";

// Import Swiper styles
import "swiper/css";
import "swiper/css/pagination";
import "swiper/css/navigation";
import banner1 from "components/carousel/images/banner1.jpg";
import banner2 from "components/carousel/images/banner2.jpg";
import "./styles.css";

// import required modules
import { Autoplay, Pagination, Navigation } from "swiper/modules";

export default function App() {
  return (
    <>
      <Swiper
        spaceBetween={30}
        //centeredSlides={true}
        autoplay={{
          delay: 1800,
          disableOnInteraction: false,
        }}
        //navigation={true}
        modules={[Autoplay]}
        className="mySwiper !h-[330px] rounded-[10px] !p-0 text-white"
      >
        <SwiperSlide>
          <img
            className="h-full w-auto rounded-xl border-2"
            src={banner1}
            alt=""
          />
        </SwiperSlide>
        <SwiperSlide>
          <img
            className="h-full w-auto rounded-l border-2"
            src={banner2}
            alt=""
          />
        </SwiperSlide>
      </Swiper>
    </>
  );
}
