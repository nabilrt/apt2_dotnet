import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
const AddProduct = () => {
  const [Name, setName] = useState("");
  const [Price, setPrice] = useState("");
  const [Quantity, setQuantity] = useState("");
  const [CategoryId, setCategoryId] = useState("");

  const history = useNavigate();

  const RegisterSubmit = () => {
    console.log(Name);
    console.log(Price);
    console.log(Quantity);
    console.log(CategoryId);

    var obj = {
      Name: Name,
      Price: Price,
      Quantity: Quantity,
      CategoryId: CategoryId,
    };

    axios
      .post("https://localhost:44347/api/product/add", obj)
      .then((resp) => {
        console.log("Success!");
      })
      .catch((err) => {
        console.log(err.response.data);
      });
  };

  return (
    <div className="container">
      <br></br>
      <h6>Add Product</h6><br></br>
      <form>
        <label>Name</label> <br />
        <input
          type="text"
          name="Name"
          id="name"
          value={Name}
          onChange={(e) => setName(e.target.value)}
          className="form-control"
        />{" "}
        <br />
        <label>Price</label> <br />
        <input
          type="text"
          name="Price"
          id="price"
          value={Price}
          onChange={(e) => setPrice(e.target.value)}
          className="form-control"
        />{" "}
        <br />
        <label>Quantity</label> <br />
        <input
          type="text"
          name="Quantity"
          id="quantity"
          value={Quantity}
          onChange={(e) => setQuantity(e.target.value)}
          className="form-control"
        />{" "}
        <br />
        <label>Category Id</label> <br />
        <input
          type="text"
          name="CategoryId"
          id="categoryId"
          value={CategoryId}
          onChange={(e) => setCategoryId(e.target.value)}
          className="form-control"
        />{" "}
        <br />
      </form>
      <button
        type="button"
        onClick={RegisterSubmit}
        className="btn btn-outline-success"
      >
        Sign Up
      </button>
    </div>
  );
};

export default AddProduct;
