import { useEffect, useState } from "react";
import Card from "components/card";
import { Link } from "react-router-dom";
import blogApi from "api/blogApi";
import moment from "moment";
const Index = (props) => {
  const [postList, setPosts] = useState([]);
  useEffect(() => {
    const getall = async () => {
      const data = await blogApi.GetBlogByUserAccount(props.userId);
      setPosts(data);
    };
    getall();
  }, []);
  console.log(postList);
  return (
    <div>
      <div className="gap-5 xl:grid-cols-2">
        <Card extra={"w-full"}>
          <div className="table-wrp mt-2 block h-[500px] overflow-x-scroll">
            {postList === undefined && (
              <div className="flex flex-col items-center justify-center">
                <p className="mt-20 text-xl text-gray-700">Request is empty!</p>
              </div>
            )}
            {postList !== undefined && (
              <table className="w-full">
                <thead className="sticky top-0 mb-1 bg-white">
                  <tr>
                    <th className="border-b border-gray-200 pb-[10px] text-start dark:!border-navy-700">
                      <p className="items-center text-xs tracking-wide text-gray-600">
                        CODE
                      </p>
                    </th>
                    <th className="border-b border-gray-200 pb-[10px] pr-[100px] text-start dark:!border-navy-700">
                      <p className="ml-10 text-xs tracking-wide text-gray-600">
                        TITLE
                      </p>
                    </th>

                    <th className="border-b border-gray-200 pb-[10px] pr-[40px] text-start dark:!border-navy-700">
                      <p className="text-xs tracking-wide text-gray-600">
                        STATUS
                      </p>
                    </th>
                    <th className="border-b border-gray-200 pb-[10px] pr-[40px] text-start dark:!border-navy-700">
                      <p className="text-xs tracking-wide text-gray-600">
                        CREATED TIME
                      </p>
                    </th>
                  </tr>
                </thead>
                <tbody className=" overflow-y-auto">
                  {postList?.map((row) => (
                    <tr key={row.id} className="border-b-2 hover:bg-gray-100">
                      <td className="flex items-center pb-[9px] pt-[9px] sm:text-[15px]">
                        <p className="text-sm font-bold text-navy-700 dark:text-white">
                          {row.id}
                        </p>
                      </td>
                      <td className="ml-10 items-center pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className="ml-10 mr-[18px] w-auto">
                          <Link to={`./blogRequest/detail/${row.id}`}>
                            <p className="text-sm font-normal text-navy-700 dark:text-white">
                              {row.title}
                            </p>
                          </Link>
                        </div>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                        <div className="w-[40px]">
                          <p className=" text-justify text-sm font-normal text-navy-700 dark:text-white">
                            {row.status}
                          </p>
                        </div>
                      </td>
                      <td className="pb-[18px] pt-[14px] sm:text-[15px]">
                        <p className=" text-justify text-sm font-normal text-navy-700 dark:text-white">
                          {moment(row.createdDate).format("DD/MM/YYYY HH:mm")}
                        </p>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            )}
          </div>
        </Card>
      </div>
    </div>
  );
};

export default Index;
