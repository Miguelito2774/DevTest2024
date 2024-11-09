import React, { ReactNode } from 'react';

interface ButtonProps {
  children: ReactNode;
  variant?: 'default' | 'outline';
  onClick?: () => void;
}

export const Button: React.FC<ButtonProps> = ({ children, variant = 'default', onClick }) => {
  const variantClasses = {
    default: 'bg-blue-500 text-white',
    outline: 'border border-gray-300 text-gray-700',
  };
  return (
    <button
      onClick={onClick}
      className={`px-4 py-2 rounded ${variantClasses[variant]}`}
    >
      {children}
    </button>
  );
};
