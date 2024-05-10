import * as React from "react";
import Box from "@mui/material/Box";
import Stepper from "@mui/material/Stepper";
import Step from "@mui/material/Step";
import StepLabel from "@mui/material/StepLabel";
import StepContent from "@mui/material/StepContent";
import Button from "@mui/material/Button";
import Paper from "@mui/material/Paper";
import Typography from "@mui/material/Typography";
import { useEffect, useState } from "react";
import moment from "moment";
import Alert from "components/alert";
import Swal from "sweetalert2";
import blogApi from "api/blogApi";
import CircularProgress from "@mui/material/CircularProgress";
import Backdrop from "@mui/material/Backdrop";
export default function VerticalLinearStepper(props) {
  const [activeStep, setActiveStep] = React.useState(0);

  const handleNext = () => {
    setActiveStep((prevActiveStep) => prevActiveStep + 1);
  };

  const handleBack = () => {
    setActiveStep((prevActiveStep) => prevActiveStep - 1);
  };

  const handleReset = () => {
    setActiveStep(0);
  };
  const [open, setOpen] = useState(false);
  const handleUpdateStatus = () => {
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
        var blogId = props.data?.id;
        var status = 2;
        var dto = { blogId, status };
        console.log(dto);
        setOpen(true);
        await blogApi.UpdateStatusBlog(dto).then(async (res) => {
          if (res.statusCode === 200) {
            setTimeout(() => {
              setOpen(false);
              props
                .setTrigger(Math.random() + 1)
                ?.toString(36)
                .substring(7);
              Alert.showSuccessAlert("Update status sucessfully!");
              setActiveStep((prevActiveStep) => prevActiveStep + 1);
            }, 1800);
          } else {
            setTimeout(() => {
              setOpen(false);

              Alert.showErrorAlert("Something went worong!");
            }, 1800);
          }
        });
      }
    });
  };

  useEffect(() => {
    if (props?.data?.status === "Pending") {
      setActiveStep(1);
    } else if (props?.data?.status === "Posted") {
      setActiveStep(2);
    }
  }, [props?.data]);

  return (
    <Box sx={{ maxWidth: 400 }}>
      <Backdrop
        sx={{ color: "#fff", zIndex: (theme) => theme.zIndex.drawer + 1 }}
        open={open}
      >
        <CircularProgress color="inherit" />
      </Backdrop>
      <Stepper activeStep={activeStep} orientation="vertical">
        <Step>
          <StepLabel
            optional={
              <Typography variant="caption">
                {props?.data?.createdDate != null
                  ? moment(props?.data?.createdDate).format("DD/MM/YYYY HH:mm ")
                  : "......"}
              </Typography>
            }
          >
            Pending
          </StepLabel>
          <StepContent>
            <Box sx={{ mb: 2 }}>
              <div>
                <Button
                  variant="contained"
                  onClick={handleUpdateStatus}
                  sx={{ mt: 1, mr: 1 }}
                >
                  Confirm
                </Button>
              </div>
            </Box>
          </StepContent>
        </Step>
        <Step>
          <StepLabel
            optional={
              <Typography variant="caption">
                {props?.data?.postedDate != null
                  ? moment(props?.data?.postedDate).format("DD/MM/YYYY HH:mm ")
                  : "......"}
              </Typography>
            }
          >
            Posted
          </StepLabel>
          <StepContent>
            <Box sx={{ mb: 2 }}>
              <div>
                <button
                  onClick={handleUpdateStatus}
                  className="linear rounded-[5px] bg-cyan-600 px-3 py-1 text-base font-medium text-white transition duration-200 hover:bg-cyan-800 active:bg-cyan-700 dark:bg-brand-400 dark:hover:bg-brand-300 dark:active:opacity-90"
                >
                  Confirm
                </button>
              </div>
            </Box>
          </StepContent>
        </Step>
      </Stepper>
    </Box>
  );
}
