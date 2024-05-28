import { createBrowserRouter, Navigate, RouteObject } from "react-router-dom";
import TicketDashboard from "../../features/tickets/dashboard/TicketDashboard";
import TicketDetails from "../../features/tickets/details/TicketDetails";
import TicketForm from "../../features/tickets/form/TicketForm";
import NotFound from "../../features/errors/NotFound";
import ServerError from "../../features/errors/ServerError";
import TestErrors from "../../features/errors/TestError";
import App from "../layout/App";

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App />,
        children: [
            {path: 'tickets', element: <TicketDashboard />},
            {path: 'tickets/:id', element: <TicketDetails />},
            {path: 'createTicket', element: <TicketForm key='create' />},
            {path: 'manage/:id', element: <TicketForm key='manage' />},
            {path: 'errors', element: <TestErrors />},
            {path: 'not-found', element: <NotFound />},
            {path: 'server-error', element: <ServerError />},
            {path: '*', element: <Navigate replace to='/not-found' />},
        ]
    }
]

export const router = createBrowserRouter(routes);