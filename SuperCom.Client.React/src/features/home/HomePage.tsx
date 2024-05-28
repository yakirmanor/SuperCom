import React from 'react';
import { Link } from 'react-router-dom';
import { Button, Container, Header, Segment, Image } from "semantic-ui-react";

export default function HomePage() {
    return (
        <Segment inverted textAlign='center' vertical className='masthead' >
            <Container text>
                <Header inverted>
                    <Image  src='/assets/supercom_logo.gif' alt='logo' style={{width: '300px', height: 'auto',  marginBottom: 12}} />
                </Header>
                <Header as='h2' inverted content='Welcome to SuperCom' />
                <Button as={Link} to='/tickets' size='huge' inverted>
                    Tickets
                </Button>
            </Container>
        </Segment>
    )
}