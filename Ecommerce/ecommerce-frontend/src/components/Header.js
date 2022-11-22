import React from "react";
import { Router, Route, Routes } from "react-router-dom";
import Home from "./Home";
import Product from "./Product";
import ProductList from "./ProductList";
import AddProduct from "./AddProduct";
import Navbar from "./Navbar";

function Header() {
  return (
    <div className="container">
      <Router>
        <Routes>
          <Route index element={<Home />} />
          <Route path="/home" element={<Home />} />
          <Route path="/productList" element={<ProductList />} />
          <Route path="/product/:id" element={<Product />}></Route>
          <Route path="/product/add" element={<AddProduct />}></Route>
        </Routes>
      </Router>
    </div>
  );
}

export default Header;
