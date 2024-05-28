import { Link } from "react-router-dom";
import { Item, Button, Icon, Segment } from "semantic-ui-react";
import { Ticket } from "../../../app/models/ticket";

interface Props {
    ticket: Ticket
}

export default function TicketListItem({ ticket }: Props) {
    return (
        <Segment.Group>
            <Segment>
                <Item.Group>
                    <Item>
                        <Item.Image size='tiny' circular src='/assets/ticket.jpg' />
                        <Item.Content>
                            <Item.Header as='a'>{ticket.name}</Item.Header>
                            <Item.Description>Supervised by Bob</Item.Description>
                        </Item.Content>
                    </Item>
                </Item.Group>
            </Segment>
            <Segment>
                <span>
                    <Icon name='clock' /> {ticket.date}
                    <Icon name='marker' /> {ticket.location}
                </span>
            </Segment>
            <Segment secondary>
                More info go here
            </Segment>
            <Segment clearing>
                <span>{ticket.description}</span>
                <Button
                    as={Link}
                    to={`/tickets/${ticket.id}`}
                    color='red'
                    floated='right'
                    content='View'
                />
            </Segment>
        </Segment.Group>
    )
}