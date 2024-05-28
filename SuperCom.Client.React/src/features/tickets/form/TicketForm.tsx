import { observer } from 'mobx-react-lite';
import { ChangeEvent, useEffect, useState } from 'react';
import { Link, useNavigate, useParams } from 'react-router-dom';
import { Button, Form, Segment } from "semantic-ui-react";
import LoadingComponent from '../../../app/layout/LoadingComponent';
import { useStore } from '../../../app/stores/store';
import {v4 as uuid} from 'uuid';

export default observer(function TicketForm() {
    const {ticketStore} = useStore();
    const {createTicket, updateTicket, 
        loading, loadTicket, loadingInitial} = ticketStore;
    const {id} = useParams();
    const navigate = useNavigate();

    const [ticket, setTicket] = useState({
        id: '',
        name: '',
        category: '',
        description: '',
        date: '',
        city: '',
        location: ''
    });

    useEffect(() => {
        if (id) loadTicket(id).then(ticket => setTicket(ticket!));
    }, [id, loadTicket]);

    function handleSubmit() {
        if (!ticket.id) {
            ticket.id = uuid();
            createTicket(ticket).then(() => navigate(`/tickets/${ticket.id}`))
        } else {
            updateTicket(ticket).then(() => navigate(`/tickets/${ticket.id}`))
        }
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
        const { name, value } = event.target;
        setTicket({ ...ticket, [name]: value })
    }

    if (loadingInitial) return <LoadingComponent content='Loading ticket...' />

    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Name' value={ticket.name} name='name' onChange={handleInputChange} />
                <Form.TextArea placeholder='Description' value={ticket.description} name='description' onChange={handleInputChange} />
                <Form.Input placeholder='Category' value={ticket.category} name='category' onChange={handleInputChange} />
                <Form.Input type='date' placeholder='Date' value={ticket.date} name='date' onChange={handleInputChange} />
                <Form.Input placeholder='City' value={ticket.city} name='city' onChange={handleInputChange} />
                <Form.Input placeholder='Loctaion' value={ticket.location} name='location' onChange={handleInputChange} />
                <Button loading={loading} floated='right' positive type='submit' content='Submit' />
                <Button as={Link} to='/tickets' floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    )
})