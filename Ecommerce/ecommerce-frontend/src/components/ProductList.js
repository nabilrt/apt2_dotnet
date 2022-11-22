import React, { useState, useEffect } from "react";
import axios from "axios";

const ProductList = () => {
  const [products, setProducts] = useState([]);
  useEffect(() => {
    axios
      .get("https://localhost:44347/api/products")
      .then((resp) => {
        console.log(resp.data);
        setProducts(resp.data);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);

  return (
    <div className="container">
      {" "}
      <br />
      <h4>Data From API</h4> <br />
      <h5>All Product Details</h5> <br />
      <table className="table table-bordered">
        <tr className="table-primary">
          <th className="table-primary">Name</th>
          <th className="table-primary">Price</th>
          <th className="table-primary">Quantity</th>
          <th className="table-primary">Action</th>
        </tr>
        {products.map((item, i) => (
          <tr key={i}>
            <td>{item.Name}</td>
            <td>{item.Price}</td>
            <td>{item.Quantity}</td>

            <br />
          </tr>
        ))}
      </table>
    </div>
  );
};

export default ProductList;
