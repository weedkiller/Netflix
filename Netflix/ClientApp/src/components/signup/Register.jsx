import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Register.css";
import { Button, Form } from "react-bootstrap";

export class Register extends Component {
  render() {
    return (
      <div id="register-container" className="col-xs-6 col-md-6 col-lg-3" >
        <span>STEP 2 OF 3</span>
        <h2>Sign up to start your free month.</h2>
        <div id="register">
          <Form method="POST">
            <Form.Group controlId="formEmail">
              <Form.Label>Email</Form.Label>
              <Form.Control type="text" placeholder="Email" />
            </Form.Group>
            <Form.Group controlId="formPassword">
              <Form.Label>Password</Form.Label>
              <Form.Control type="password" placeholder="Password" />
            </Form.Group>
            <Link to="/signup/payment">
              <Button>Continue</Button>
            </Link>
          </Form>
        </div>
      </div>
    );
  }
}