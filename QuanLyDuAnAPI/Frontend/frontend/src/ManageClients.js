import React, { useEffect, useState } from "react";
import axios from "axios";

const ManageClients = () => {
    const [clients, setClients] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/api/clients")
            .then(response => setClients(response.data))
            .catch(error => console.error("Error fetching clients:", error));
    }, []);

    return (
        <div>
            <h2>Manage Clients</h2>
            <button>+ New Client</button>
            <ul>
                {clients.map(client => (
                    <li key={client.id}>{client.name} - {client.address}</li>
                ))}
            </ul>
        </div>
    );
};

export default ManageClients;
