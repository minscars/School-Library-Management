import * as React from "react";
import Pagination from "@mui/material/Pagination";
import Stack from "@mui/material/Stack";

export default function PaginationRounded(props) {
  return (
    <Stack spacing={2}>
      <Pagination
        //onChange={}
        variant="outlined"
        shape="rounded"
      />
    </Stack>
  );
}
