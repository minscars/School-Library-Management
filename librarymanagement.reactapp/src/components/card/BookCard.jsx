import { IoHeart, IoHeartOutline } from "react-icons/io5";
import { useState } from "react";
import { ToastContainer, toast } from "react-toastify";
import { Link } from "react-router-dom";
import Card from "components/card";
import "react-toastify/dist/ReactToastify.css";
import Rating from "@mui/material/Rating";
const NftCard = ({ data }) => {
  const [value, setValue] = useState(null);
  return (
    <Card
      extra={`flex items-center flex-col w-full !h-[250px] !p-4 3xl:p-![18px] bg-white `}
    >
      <div className="h-full w-full ">
        <div className="relative flex w-full justify-center">
          <img
            src={data.image}
            className="mb-3 h-[120px] w-auto rounded-l border-2 3xl:h-full 3xl:w-full"
            alt={data.title}
          />
        </div>

        <div className="mb-1 flex items-center justify-center px-1">
          <div className="mb-2">
            <p className="text-center text-sm font-bold text-navy-700 dark:text-white">
              {" "}
              {data.title}{" "}
            </p>
            <p className="text-center text-sm font-medium text-gray-600">By</p>
            {data.authors?.map((item) => (
              <p
                key={item.id}
                className="text-center text-sm font-medium text-gray-600"
              >
                {item.name}{" "}
              </p>
            ))}
          </div>
        </div>
      </div>
      {/* <p className="mb-2 text-center text-sm font-bold text-brand-500 dark:text-white">
        {data.category}
      </p> */}
      {/* <div className="row flex items-center">
        <Rating
          className="items-center"
          name="half-rating"
          value={data.rating}
          size="small"
          defaultValue={0}
          precision={0.5}
          onChange={(event, newValue) => {
            setValue(newValue);
          }}
        />
        <p className="text-center text-sm font-medium text-gray-600">
          | Borrowed: {data.checkout_visit}
        </p>
      </div> */}
    </Card>
  );
};

export default NftCard;
