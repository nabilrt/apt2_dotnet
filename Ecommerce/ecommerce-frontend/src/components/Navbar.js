import React from "react";
import { Link } from "react-router-dom";

function Navbar() {
  return (
    <div className="container">
      <br />
      <div className="btn-group">
        <Link to="/home" className="btn btn-outline-primary">
          Home |
        </Link>
        <Link to="/product/add" className="btn btn-outline-primary">
          Add Product |
        </Link>
        <Link to="/productList" className="btn btn-outline-primary">
           Product List
        </Link>
      </div>
    </div>
  );
}

export default Navbar;
