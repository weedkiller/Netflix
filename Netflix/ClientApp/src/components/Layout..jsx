import React, { Component } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import NavMenu from './shared/NavMenu';

export class Layout extends Component {
  render() {
    return (
      <Container fluid>
        <Row height={50}>
          <Col sm={12}>
            <NavMenu />
          </Col>
        </Row>
        <Row>
          <Col sm={12}>
            {this.props.children}
          </Col>
        </Row>
      </Container>
    );
  }
}
