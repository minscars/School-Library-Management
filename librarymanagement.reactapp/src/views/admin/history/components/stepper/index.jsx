import * as React from "react";
import Box from "@mui/material/Box";
import Stepper from "@mui/material/Stepper";
import Step from "@mui/material/Step";
import StepLabel from "@mui/material/StepLabel";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import { useEffect, useState } from "react";
import bookRequestApi from "api/bookRequest";

import Alert from "components/alert";
import Swal from "sweetalert2";
import moment from "moment";
import { toast, ToastContainer } from "react-toastify";
import Backdrop from "@mui/material/Backdrop";
import CircularProgress from "@mui/material/CircularProgress";
export default function HorizontalLinearStepper(props) {
  const [activeStep, setActiveStep] = React.useState(1);
  const [open, setOpen] = useState(false);
  const handleUpdateStatus = () => {
    let status = 0;
    if (props.data?.status === "Pending") {
      status = 3; //approve
    } else if (props.data?.status === "Approve") {
      status = 4; //borrowing
    } else if (props.data?.status === "Borrowing") {
      status = 5; //returned
    }

    if (status !== 0 && status !== 4 && status !== 5) {
      // thêm xác nhận
      Swal.fire({
        title: "Are you sure?",
        text: "You should recheck the user information before update status!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, I checked it!",
      }).then(async (result) => {
        if (result.isConfirmed) {
          setOpen(true);
          var bookRequestId = props.data?.id;
          const request = { bookRequestId, status };
          request.bookDetailId = props.data?.bookDetailId;
          request.publishedBookId = props.data?.publishedBookId;
          await bookRequestApi.UpdateStatus(request).then(async (res) => {
            if (res?.statusCode === 200) {
              setTimeout(() => {
                props
                  .setTrigger(Math.random() + 1)
                  ?.toString(36)
                  .substring(7);
                setOpen(false);
                Alert.showSuccessAlert(res?.message);
                setActiveStep((prevActiveStep) => prevActiveStep + 1);
              }, 2200);
            } else {
              setTimeout(() => {
                setOpen(false);
                Alert.showErrorAlert(res?.message);
              }, 2200);
            }
          });
        }
      });

      // props.setTrigger();
    }
    if (status === 4 || status === 5) {
      Swal.fire({
        title: "Are you sure?",
        input: "text",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!",
      }).then(async (result) => {
        if (result.isConfirmed) {
          setOpen(true);
          var bookRequestId = props.data?.id;
          const request = { bookRequestId, status };
          request.bookDetailId = props.data?.bookDetailId;
          request.publishedBookId = props.data?.publishedBookId;
          request.bookTaked = result.value;

          if (request.bookTaked === "") {
            setOpen(false);
            toast.error("You must enter the code book!");
          } else {
            await bookRequestApi.UpdateStatus(request).then(async (res) => {
              if (res?.statusCode === 200) {
                setTimeout(() => {
                  props
                    .setTrigger(Math.random() + 1)
                    ?.toString(36)
                    .substring(7);
                  setOpen(false);
                  Alert.showSuccessAlert(res?.message);
                  setActiveStep((prevActiveStep) => prevActiveStep + 1);
                }, 2200);
              } else {
                setTimeout(() => {
                  setOpen(false);
                  Alert.showErrorAlert(res?.message);
                }, 2200);
              }
            });
          }
        }
      });
    }
  };

  useEffect(() => {
    if (props?.data?.status === "Pending") {
      setActiveStep(1);
    } else if (props?.data?.status === "Approve") {
      setActiveStep(2);
    } else if (props?.data?.status === "Borrowing") {
      setActiveStep(3);
    } else if (props?.data?.status === "Returned") {
      setActiveStep(4);
    }
  }, [props?.data]);
  console.log(props?.data);
  return (
    <Box sx={{ width: "100%" }}>
      <Stepper activeStep={activeStep}>
        <Step>
          <StepLabel
            optional={
              props?.data?.status === "Pending" ||
              props?.data?.status === "Approve" ||
              props?.data?.status === "Borrowing" ||
              props?.data?.status === "Returned" ? (
                <Typography fontSize={"small"} color={"blue-gray"}>
                  {props?.data?.createdTime != null
                    ? moment(props?.data?.createdTime).format(
                        "DD/MM/YYYY HH:mm "
                      )
                    : "......"}
                </Typography>
              ) : null
            }
          >
            Pending
          </StepLabel>
        </Step>
        <Step>
          <StepLabel
            optional={
              props?.data?.status === "Approve" ||
              props?.data?.status === "Borrowing" ||
              props?.data?.status === "Returned" ? (
                <Typography fontSize={"small"} color={"blue-gray"}>
                  {props?.data?.approvedTime != null
                    ? moment(props?.data?.approvedTime).format(
                        "DD/MM/YYYY HH:mm "
                      )
                    : "......"}
                </Typography>
              ) : null
            }
          >
            Approve
          </StepLabel>
        </Step>
        <Step>
          <StepLabel
            optional={
              props?.data?.status === "Borrowing" ||
              props?.data?.status === "Returned" ? (
                <Typography fontSize={"small"} color={"blue-gray"}>
                  {props?.data?.borrowedTime != null
                    ? moment(props?.data?.borrowedTime).format(
                        "DD/MM/YYYY HH:mm "
                      )
                    : "......"}
                </Typography>
              ) : null
            }
          >
            Borrowing
          </StepLabel>
        </Step>
        <Step>
          <StepLabel
            optional={
              props?.data?.status === "Returned" ? (
                <Typography fontSize={"small"} color={"blue-gray"}>
                  {props?.data?.returnedTime != null
                    ? moment(props?.data?.returnedTime).format(
                        "DD/MM/YYYY HH:mm "
                      )
                    : "......"}
                </Typography>
              ) : null
            }
          >
            Returned
          </StepLabel>
        </Step>
      </Stepper>

      {props.data?.status !== "Returned" && (
        <Box sx={{ display: "flex", justifyContent: "end", pt: 2 }}>
          <button
            onClick={handleUpdateStatus}
            className="linear rounded-[5px] bg-cyan-600 px-3 py-1 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
          >
            Confirm
          </button>
        </Box>
      )}
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={open}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
      <ToastContainer />
    </Box>
  );
}
