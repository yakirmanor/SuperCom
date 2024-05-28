import { observer } from 'mobx-react-lite';
import React from 'react'
import {Button, Header, Item, Segment, Image} from 'semantic-ui-react'
import {Ticket} from "../../../app/models/ticket";

const ticketImageStyle = {
    filter: 'brightness(30%)'
};

const ticketImageTextStyle = {
    position: 'absolute',
    bottom: '5%',
    left: '5%',
    width: '100%',
    height: 'auto',
    color: 'white'
};

interface Props {
    ticket: Ticket
}

export default observer (function TicketDetailedHeader({ticket}: Props) {
    return (
        <Segment.Group>
            <Segment basic attached='top' style={{padding: '0'}}>
                <Image src={`/assets/categoryImages/${ticket.category}.jpg`} fluid style={ticketImageStyle}/>
                <Segment style={ticketImageTextStyle} basic>
                    <Item.Group>
                        <Item>
                            <Item.Content>
                                <Header
                                    size='huge'
                                    content={ticket.name}
                                    style={{color: 'white'}}
                                />
                                <p>{ticket.date}</p>
                                <p>
                                Supervised by <strong>Bob</strong>
                                </p>
                            </Item.Content>
                        </Item>
                    </Item.Group>
                </Segment>
            </Segment>
            <Segment clearing attached='bottom'>
                <Button color='red'>Delete Ticket</Button>
                <Button>Disable Ticket</Button>
                <Button color='orange' floated='right'>
                    Manage Ticket
                </Button>
            </Segment>
        </Segment.Group>
    )
})