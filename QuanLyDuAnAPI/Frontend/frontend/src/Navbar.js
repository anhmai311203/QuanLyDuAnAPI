import { Link } from "react-router-dom";

const Navbar = () => {
    return (
        <nav>
            <ul>
                <li><Link to="/clients">Manage Clients</Link></li>
                <li><Link to="/tasks">Manage Tasks</Link></li>
            </ul>
        </nav>
    );
};

export default Navbar;
