import { BrowserRouter as Router, Route, Routes, Navigate } from "react-router-dom";
import Navbar from "./Navbar";
import ManageClients from "./ManageClients";
import ManageTasks from "./ManageTasks";

function App() {
    return (
        <Router>
            <div>
                <Navbar />
                <Routes>
                    <Route path="/" element={<Navigate to="/clients" />} />
                    <Route path="/clients" element={<ManageClients />} />
                    <Route path="/tasks" element={<ManageTasks />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;
