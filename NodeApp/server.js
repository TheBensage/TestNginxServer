import express from "express";

const app = express();
const port = 3000;

app.get("/", (_, res) => res.send("Hello from Node App!"));
app.get("/api", (_, res) => res.send("This is the Node /api endpoint!"));
app.get("/api/test", (_, res) =>
  res.send("This is the Node /api/test endpoint!")
);

app.listen(port, "0.0.0.0", () => {
  console.log(`Node app listening at http://localhost:${port}`);
});
