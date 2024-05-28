import React from 'react';
import { Menu, Header } from 'semantic-ui-react';
import Calendar from 'react-calendar';

export default function TicketFilters() {
    return (
        <>
            <Menu vertical size='large' style={{ width: '100%', marginTop: 25 }}>
                <Header icon='filter' attached color='red' content='Filters' />
                <Menu.Item content='All Tickets' />
                <Menu.Item content="Prison" />
                <Menu.Item content="House Arrest" />
            </Menu>
            <Header icon='calendar' attached color='red' content='Select date' />
            <Calendar />
        </>
    );
}