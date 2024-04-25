import Card from "components/card";
import * as React from "react";
import PropTypes from "prop-types";
import Tabs from "@mui/material/Tabs";
import Tab from "@mui/material/Tab";
import Typography from "@mui/material/Typography";
import Box from "@mui/material/Box";
import BookRequestTab from "./bookRequest/index";
import BlogRequestTab from "./blogRequest/index";
import jwt from "jwt-decode";
function CustomTabPanel(props) {
  const { children, value, index, setTrigger, ...other } = props;

  return (
    <div
      role="tabpanel"
      hidden={value !== index}
      id={`simple-tabpanel-${index}`}
      aria-labelledby={`simple-tab-${index}`}
      {...other}
    >
      {value === index && (
        <Box sx={{ p: 3 }}>
          <Typography>{children}</Typography>
        </Box>
      )}
    </div>
  );
}

CustomTabPanel.propTypes = {
  children: PropTypes.node,
  index: PropTypes.number.isRequired,
  value: PropTypes.number.isRequired,
};

function a11yProps(index) {
  return {
    id: `simple-tab-${index}`,
    "aria-controls": `simple-tabpanel-${index}`,
  };
}

const History = () => {
  var token = window.localStorage.getItem("token");
  const userLogin = jwt(token);
  const [valueX, setValueX] = React.useState(0);

  const handleChange = (event, newValue) => {
    setValueX(newValue);
  };
  return (
    <div>
      <div className="gap-5 xl:grid-cols-2">
        <Card extra={"w-full px-4 pb-6 sm:overflow-x-auto"}>
          <Box sx={{ width: "100%" }}>
            <Box sx={{ borderBottom: 1, borderColor: "divider" }}>
              <Tabs
                value={valueX}
                onChange={handleChange}
                aria-label="basic tabs example"
              >
                <Tab label="Book request" {...a11yProps(0)} />
                <Tab label="Blog request" {...a11yProps(1)} />
              </Tabs>
            </Box>
            <CustomTabPanel value={valueX} index={0}>
              <BookRequestTab userId={userLogin?.id} />
            </CustomTabPanel>
            <CustomTabPanel value={valueX} index={1}>
              <BlogRequestTab userId={userLogin?.id} />
            </CustomTabPanel>
          </Box>
        </Card>
      </div>
    </div>
  );
};
export default History;
