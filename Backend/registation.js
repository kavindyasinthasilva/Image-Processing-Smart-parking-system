import React, { Component } from 'react';
import {Button, Col, Container, Form, Row} from "react-bootstrap";

export default class registation extends Component {


      constructor(props)
      {
          super(props)


          this.onChangeUserEmail = this.onChangeUserEmail.bind(this);
          this.onChangeuserpassword = this.onChangeuserpassword.bind(this);
          this.onSubmit=this.onSubmit.bind(this);


           this.state ={


                 useremail:'',
                 userpassword:''
                


           }

         
        }


        onChangeUserEmail(e) {
            this.setState({
                useremai: e.target.value
            });
        }


        onChangeuserpassword(e)
        {

            this.setState({
                userpassword: e.target.value
            });


        }



        onSubmit(e)
        {




            
        }
      






    


    render() {
        return (
            <div>


<Container fluid="md">
  <Row className="sky">
    <Col>
    
    
    
    <Form onSubmit={this.onSubmit}>
  <Form.Group controlId="formBasicEmail">
    <Form.Label>Email address</Form.Label>
    <Form.Control type="email" placeholder="Enter email"  value={this.state.useremail} onChange={this.onChangeUserEmail} required />
    <Form.Text className="text-muted">
      We'll never share your email with anyone else.
    </Form.Text>
  </Form.Group>

  <Form.Group controlId="formBasicPassword">
    <Form.Label>Password</Form.Label>
    <Form.Control type="password" placeholder="Password" value={this.state.userpassword} onChange={this.userpassword}   required />
  </Form.Group>
  <Form.Group controlId="formBasicCheckbox">
    <Form.Check type="checkbox" label="Check me out" />
  </Form.Group>
  <Button variant="primary" type="submit">
    Submit
  </Button>
</Form>
    
    
    
    
    
    
    
    
    
    
    </Col>
  </Row>
</Container>
                
            </div>
        )
    }
}
