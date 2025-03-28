import React, { useEffect, useState } from "react";
import axios from "axios";

const ManageTasks = () => {
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        axios.get("http://localhost:5000/api/tasks")
            .then(response => setTasks(response.data))
            .catch(error => console.error("Error fetching tasks:", error));
    }, []);

    return (
        <div>
            <h2>Manage Tasks</h2>
            <button>+ New Task</button>
            <ul>
                {tasks.map(task => (
                    <li key={task.id}>{task.name} - {task.type}</li>
                ))}
            </ul>
        </div>
    );
};

export default ManageTasks;
